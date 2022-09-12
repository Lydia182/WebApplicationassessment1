@ModelType IEnumerable(Of WebApplicationassessment1.Student)
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
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Surname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.contract_Number)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.age)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Surname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.contract_Number)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.age)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Student_ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Student_ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Student_ID })
        </td>
    </tr>
Next

</table>
