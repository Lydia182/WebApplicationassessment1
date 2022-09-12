@ModelType IEnumerable(Of WebApplicationassessment1.Registration)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Course.Course_Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.School_year.School_year1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Student.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Subject.Subject_Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.date)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Course.Course_Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.School_year.School_year1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Student.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Subject.Subject_Name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Registration_ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Registration_ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Registration_ID })
        </td>
    </tr>
Next

</table>
