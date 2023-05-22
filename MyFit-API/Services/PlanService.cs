using MyFit_API.Exceptions.PlanException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class PlanService
    {

        private PlanRepository _planRepository = new PlanRepository();

        public List<Plan>? GetAllPlans()
        {
            List<Plan>? plans = _planRepository.GetAllPlans();
            return plans != null ? plans : new List<Plan>();
        }

        public Plan GetPlanById(byte id)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            return plan;
        }

        public string GetPlanName(byte id)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            return plan.Name;
        }

        public byte GetPlanValue(byte id)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            return plan.Value;
        }

        public float GetPlanPrice(byte id)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            return plan.Price;
        }

        public string? GetPlanDescription(byte id)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            return plan.Description;
        }

        public void AddPlan(Plan plan)
        {
            _planRepository.AddPlan(plan);
        }

        public void SetPlanName(byte id, string name)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.SetPlanName(id, name);
        }

        public void SetPlanValue(byte id, byte value)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.SetPlanValue(id, value);
        }

        public void SetPlanSubtitle(byte id, string subtitle)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.SetPlanSubtitle(id, subtitle);
        }

        public void SetPlanColor(byte id, string color)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.SetPlanColor(id, color);
        }

        public void SetPlanPrice(byte id, float price)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.SetPlanPrice(id, price);
        }

        public void SetPlanDescription(byte id, string description)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.SetPlanDescription(id, description);
        }

        public void DeletePlanById(byte id)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.DeletePlanById(id);
        }

        public int CountPlans()
        {
            return _planRepository.CountPlans();
        }

        public long CountHowManyPlansById(byte id)
        {
            return _planRepository.CountHowManyPlansById(id);
        }

    }
}
