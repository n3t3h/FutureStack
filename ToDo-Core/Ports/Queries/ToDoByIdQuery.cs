﻿using Darker;
using ToDoCore.Model;

namespace ToDoCore.Ports.Queries
{
    public class ToDoByIdQuery : IQueryRequest<ToDoByIdQuery.Result>
    {
        public int Id { get; }

        public ToDoByIdQuery(int id)
        {
            Id = id;
        }

        public sealed class Result : IQueryResponse
        {
            public Result(int id, string title)
            {
                Id = id;
                Title = title;
            }

            public Result(ToDoItem toDoItem)
            {
                Id = toDoItem.Id;
                Title = toDoItem.Title;
            }

            public int Id { get; }
            public string Title { get; }
        }
    }
}