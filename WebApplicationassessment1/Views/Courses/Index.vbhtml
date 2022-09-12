@ModelType IEnumerable(Of WebApplicationassessment1.Course)
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
            @Html.DisplayNameFor(Function(model) model.Course_Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Course_Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Description)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Course_ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Course_ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Course_ID })
        </td>
    </tr>
Next

</table>
