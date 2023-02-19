using Clean_Architecture.Application.Common.Mappings;
using Clean_Architecture.Domain.Entities;

namespace Clean_Architecture.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}
