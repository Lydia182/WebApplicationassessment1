@ModelType WebApplicationassessment1.Student
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
