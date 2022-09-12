@ModelType IEnumerable(Of WebApplicationassessment1.School_year)
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
            @Html.DisplayNameFor(Function(model) model.School_year1)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.School_year1)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.School_year_ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.School_year_ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.School_year_ID })
        </td>
    </tr>
Next

</table>
