Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebApplicationassessment1

Namespace Controllers
    Public Class RegistrationsController
        Inherits System.Web.Mvc.Controller

        Private db As New AssessmentEntities

        ' GET: Registrations
        Function Index() As ActionResult
            Dim registrations = db.Registrations.Include(Function(r) r.Course).Include(Function(r) r.School_year).Include(Function(r) r.Student).Include(Function(r) r.Subject)
            Return View(registrations.ToList())
        End Function

        ' GET: Registrations/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim registration As Registration = db.Registrations.Find(id)
            If IsNothing(registration) Then
                Return HttpNotFound()
            End If
            Return View(registration)
        End Function

        ' GET: Registrations/Create
        Function Create() As ActionResult
            ViewBag.Course_ID = New SelectList(db.Courses, "Course_ID", "Course_Name")
            ViewBag.School_year_ID = New SelectList(db.School_year, "School_year_ID", "School_year1")
            ViewBag.Student_ID = New SelectList(db.Students, "Student_ID", "Name")
            ViewBag.Subject_ID = New SelectList(db.Subjects, "Subject_ID", "Subject_Name")
            Return View()
        End Function

        ' POST: Registrations/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Registration_ID,date,Student_ID,Course_ID,Subject_ID,School_year_ID")> ByVal registration As Registration) As ActionResult
            If ModelState.IsValid Then
                db.Registrations.Add(registration)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Course_ID = New SelectList(db.Courses, "Course_ID", "Course_Name", registration.Course_ID)
            ViewBag.School_year_ID = New SelectList(db.School_year, "School_year_ID", "School_year1", registration.School_year_ID)
            ViewBag.Student_ID = New SelectList(db.Students, "Student_ID", "Name", registration.Student_ID)
            ViewBag.Subject_ID = New SelectList(db.Subjects, "Subject_ID", "Subject_Name", registration.Subject_ID)
            Return View(registration)
        End Function

        ' GET: Registrations/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim registration As Registration = db.Registrations.Find(id)
            If IsNothing(registration) Then
                Return HttpNotFound()
            End If
            ViewBag.Course_ID = New SelectList(db.Courses, "Course_ID", "Course_Name", registration.Course_ID)
            ViewBag.School_year_ID = New SelectList(db.School_year, "School_year_ID", "School_year1", registration.School_year_ID)
            ViewBag.Student_ID = New SelectList(db.Students, "Student_ID", "Name", registration.Student_ID)
            ViewBag.Subject_ID = New SelectList(db.Subjects, "Subject_ID", "Subject_Name", registration.Subject_ID)
            Return View(registration)
        End Function

        ' POST: Registrations/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Registration_ID,date,Student_ID,Course_ID,Subject_ID,School_year_ID")> ByVal registration As Registration) As ActionResult
            If ModelState.IsValid Then
                db.Entry(registration).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Course_ID = New SelectList(db.Courses, "Course_ID", "Course_Name", registration.Course_ID)
            ViewBag.School_year_ID = New SelectList(db.School_year, "School_year_ID", "School_year1", registration.School_year_ID)
            ViewBag.Student_ID = New SelectList(db.Students, "Student_ID", "Name", registration.Student_ID)
            ViewBag.Subject_ID = New SelectList(db.Subjects, "Subject_ID", "Subject_Name", registration.Subject_ID)
            Return View(registration)
        End Function

        ' GET: Registrations/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim registration As Registration = db.Registrations.Find(id)
            If IsNothing(registration) Then
                Return HttpNotFound()
            End If
            Return View(registration)
        End Function

        ' POST: Registrations/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim registration As Registration = db.Registrations.Find(id)
            db.Registrations.Remove(registration)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
