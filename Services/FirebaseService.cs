using EventManagement.Models;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventManagement.Services
{
    public class FirebaseService
    {
        private readonly IJSRuntime _js;
        public FirebaseService(IJSRuntime js) => _js = js;

        
        public async Task<List<EventModel>> GetEventsAsync()
        {
            return await _js.InvokeAsync<List<EventModel>>("firebaseInterop.getEvents");
        }

        
        public async Task<List<FeedbackModel>> GetFeedbacksAsync(string eventId)
        {
            return await _js.InvokeAsync<List<FeedbackModel>>("firebaseInterop.getFeedbacks", eventId);
        }

        
        public async Task<bool> AddFeedbackAsync(string eventId, FeedbackModel feedback)
        {
            var result = await _js.InvokeAsync<dynamic>("firebaseInterop.SaveFeedback", eventId, feedback);
            return result.success;
        }

        
    }
}