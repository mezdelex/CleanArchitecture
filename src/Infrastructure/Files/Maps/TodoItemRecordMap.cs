using System.Globalization;
using Clean_Architecture.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace Clean_Architecture.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
