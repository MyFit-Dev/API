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

        public string GetPlanDescription(byte id)
        {
            Plan? plan = _planRepository.GetPlanById(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not foud");

            return plan.Description;
        }

    }
}
