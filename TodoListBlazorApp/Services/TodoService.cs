using TodoListBlazorApp.Models;
using System.Net.Http.Json;

namespace TodoListBlazorApp.Services
{
    public class TodoService
    {
        private readonly HttpClient _httpClient;

        public TodoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TodoModel>> GetTodosAsync(int pageNumber, int pageSize)
        {
            var response = await _httpClient.GetFromJsonAsync<List<TodoModel>>($"https://todo-api.bestcar.id/api/v1/todo?pageNumber={pageNumber}&pageSize={pageSize}");
            return response ?? new List<TodoModel>();
        }

        public async Task<bool> AddTodoAsync(TodoModel newTodo)
        {
            var response = await _httpClient.PostAsJsonAsync("https://todo-api.bestcar.id/api/v1/todo", newTodo);
            return response.IsSuccessStatusCode;
        }
    }
}

