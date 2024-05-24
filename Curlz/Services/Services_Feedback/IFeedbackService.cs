using Curlz.Models;

namespace Curlz.Services.Services_Feedback
{
    public interface IFeedbackService
    {
        public List<Feedback> GetFeedback();
        Feedback GetFeedback(int id);
        int AddFeedback(Feedback Feedback);
        int UpdateFeedback(int id, Feedback Feedback);
        int DeleteFeedback(int id);
    }
}
