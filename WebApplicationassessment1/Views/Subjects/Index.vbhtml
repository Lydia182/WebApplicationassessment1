@ModelType IEnumerable(Of WebApplicationassessment1.Subject)
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
            @Html.DisplayNameFor(Function(model) model.Subject_Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Subject_Name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Subject_ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Subject_ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Subject_ID })
        </td>
    </tr>
Next

</table>
