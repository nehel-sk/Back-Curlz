using Curlz.Models;

namespace Curlz.Repositories.Repositories_Feedback
{
    public interface IFeedbackRepository
    {
        List<Feedback> GetFeedback();
        Feedback GetFeedback(int id);
        int AddFeedback(Feedback Feedback);
        int UpdateFeedback(int id, Feedback Feedback);
        int DeleteFeedback(int id);
    }
}
