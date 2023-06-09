﻿using MyFit_API.Exceptions.PlanException;
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
            string? Name = _planRepository.GetPlanName(id);

            return Name != null ? Name : throw new PlanNotFoundException("Plan not found");
        }

        public string GetPlanSubtitle(byte id)
        {
            string? Subtitle = _planRepository.GetPlanSubtitle(id);

            return Subtitle != null ? Subtitle : throw new PlanNotFoundException("Plan not found");
        }

        public string GetPlanColor(byte id)
        {
            string? Color = _planRepository.GetPlanColor(id);

            return Color != null ? Color : throw new PlanNotFoundException("Plan not found");
        }

        public byte GetPlanValue(byte id)
        {
            byte? Value = _planRepository.GetPlanValue(id);

            return (byte)(Value != null ? Value : throw new PlanNotFoundException("Plan not found"));
        }

        public float GetPlanPrice(byte id)
        {
            float? Price = _planRepository.GetPlanPrice(id);

            return (float)(Price != null ? Price : throw new PlanNotFoundException("Plan not found"));
        }

        public string? GetPlanDescription(byte id)
        {
            string? Description = _planRepository.GetPlanDescription(id);

            return Description != null ? Description : throw new PlanNotFoundException("Plan not found");
        }

        public void AddPlan(Plan plan)
        {
            _planRepository.AddPlan(plan);
        }

        public void SetPlanName(byte id, string name)
        {
            if (!_planRepository.ExistsForm(id))
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.SetPlanName(id, name);
        }

        public void SetPlanValue(byte id, byte value)
        {
            if (!_planRepository.ExistsForm(id))
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.SetPlanValue(id, value);
        }

        public void SetPlanSubtitle(byte id, string subtitle)
        {
            if (!_planRepository.ExistsForm(id))
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.SetPlanSubtitle(id, subtitle);
        }

        public void SetPlanColor(byte id, string color)
        {
            if (!_planRepository.ExistsForm(id))
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.SetPlanColor(id, color);
        }

        public void SetPlanPrice(byte id, float price)
        {
            if (!_planRepository.ExistsForm(id))
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.SetPlanPrice(id, price);
        }

        public void SetPlanDescription(byte id, string description)
        {
            if (!_planRepository.ExistsForm(id))
                throw new PlanNotFoundException("Plan not foud");

            _planRepository.SetPlanDescription(id, description);
        }

        public void DeletePlanById(byte id)
        {
            if (!_planRepository.ExistsForm(id))
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
