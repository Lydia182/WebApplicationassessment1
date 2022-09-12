@ModelType WebApplicationassessment1.School_year
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>School_year</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.School_year1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.School_year1)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.School_year_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
