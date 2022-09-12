@ModelType WebApplicationassessment1.Registration
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Registration</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.date)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.date)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Course.Course_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Course.Course_Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.School_year.School_year1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.School_year.School_year1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Student.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Student.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Subject.Subject_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Subject.Subject_Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Registration_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
