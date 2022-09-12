@ModelType WebApplicationassessment1.Subject
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Subject</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Subject_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Subject_Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Subject_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
