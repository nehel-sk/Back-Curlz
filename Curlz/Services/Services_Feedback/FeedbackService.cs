using Curlz.Exception;
using Curlz.Models;
using Curlz.Repositories.Repositories_Feedback;

namespace Curlz.Services.Services_Feedback
{
    public class FeedbackService: IFeedbackService
    {
        private readonly IFeedbackRepository repo;

        public FeedbackService(IFeedbackRepository repo)
        {

            this.repo = repo;
        }
        public List<Feedback> GetFeedback()
        {
            return repo.GetFeedback();
        }
        public int AddFeedback(Feedback Feedback)
        {
            if (repo.GetFeedback(Feedback.Feedback_Id) != null)
            {
                throw new FeedbackAlreadyExistsException($"Feedback with Feedback id {Feedback.Feedback_Id} already exists");
            }
            return repo.AddFeedback(Feedback);
        }
        public int DeleteFeedback(int id)
        {
            if (repo.GetFeedback(id) == null)
            {
                throw new FeedbackNotFoundException($"Feedback with Feedback id {id} does not exists");
            }
            return repo.DeleteFeedback(id);
        }

        public Feedback GetFeedback(int id)
        {
            Feedback c = repo.GetFeedback(id);
            if (c == null)
            {
                throw new FeedbackNotFoundException($"Feedback with Feedback id {id} does not exists");
            }
            return c;
        }
        public int UpdateFeedback(int id, Feedback Feedback)
        {
            if (repo.GetFeedback(id) == null)
            {
                throw new FeedbackNotFoundException($"Feedback with Feedback id {id} does not exists");
            }
            return repo.UpdateFeedback(id, Feedback);
        }
    }
}
