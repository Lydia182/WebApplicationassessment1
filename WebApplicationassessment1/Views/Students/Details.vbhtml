@ModelType WebApplicationassessment1.Student
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Student</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Surname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Surname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.contract_Number)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.contract_Number)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.age)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.age)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Student_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
