
using HCI2_Requirements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessibleMealPlanner.BLL
{
    public class MealManager
    {
        /*
        private readonly UserDAO _userDao = new UserDAO();
        private readonly MealDAO _mealDao = new MealDAO();

        // Business Rule: Ensure a meal is safe before scheduling
        public bool ScheduleSafeMeal(int userId, int mealId, DateTime date)
        {
            var user = _userDao.GetUserByID(userId);
            var meal = _mealDao.GetMealByID(mealId);

            // Check if user is allergic to any ingredients in the meal
            if (CheckAllergySafety(user, meal))
            {
                // Encapsulate the scheduling logic
                return _mealDao.InsertScheduledMeal(userId, mealId, date);
            }
            return false;
        }

        // Private encapsulated method for a specific business rule
        private bool CheckAllergySafety(UserModel user, MealModel meal)
        {
            if (string.IsNullOrEmpty(user.Allergies)) return true;
            if (string.IsNullOrEmpty(meal.Ingredients)) return true;

            // ... Logic to check if any user allergy is present in meal ingredients
            return true; // Placeholder for actual logic
        }
        */
    }
}