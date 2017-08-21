using System;
using System.Collections.Generic;
using DemoCard.Styles;

namespace DemoCard.Views
{
    public class CardData : List<Card>
    {
        public CardData()
        {
            //Add Data Item to Card List
            Add(new Card()
            {
                TitleSource = "dishesfa.jpg",
                Status = CardStatus.Completed,
                Description = "Structures",
                DueDate = DateTime.Now.AddDays(1),
                DirationInMinutes = 45,
                StatusMessage = "1 Day left!",
                StatusMessageFileSource = StyleKit.Icons.Alert,
                ActionMessage = "Resume",
                ActionMessageFileSource = StyleKit.Icons.Share,
                RatingOfProduct = "3",
                CompanyName = "Taj Mahal",
                Discount = "20% Discount",
                ContactNo = "000-555-1212",
                WebSiteURL = "www.domain.com",
            });

            Add(new Card()
            {
                TitleSource = "dishesfa.jpg",
                Status = CardStatus.Alert,
                Description = "Modules & Functions",
                DueDate = DateTime.Now.AddDays(3),
                DirationInMinutes = 60,
                StatusMessage = "3 Days left!",
                StatusMessageFileSource = StyleKit.Icons.Alert,
                ActionMessage = "Resume",
                ActionMessageFileSource = StyleKit.Icons.Share,
                RatingOfProduct = "4",
                CompanyName = "Tower of Pisa",
                Discount = "35% Discount",
                ContactNo = "000-555-1212",
                WebSiteURL = "www.domain.com",
            });

            Add(new Card()
            {
                TitleSource = "dishesfa.jpg",
                Status = CardStatus.Completed,
                Description = "Control Flow (if, while and for loop)",
                DueDate = DateTime.Now.AddDays(-5),
                DirationInMinutes = 35,
                StatusMessage = "Assignment Completed",
                StatusMessageFileSource = StyleKit.Icons.Completed,
                ActionMessage = "Report",
                ActionMessageFileSource = StyleKit.Icons.Share,
                RatingOfProduct = "2",
                CompanyName = "Effiel Tower",
                Discount = "35% Discount",
                ContactNo = "000-555-1212",
                WebSiteURL = "www.domain.com",
            });

            Add(new Card()
            {
                TitleSource = "dishesfa.jpg",
                Status = CardStatus.Alert,
                Description = "The World",
                DueDate = DateTime.Now.AddDays(-8),
                DirationInMinutes = 25,
                StatusMessage = "Unresolved",
                StatusMessageFileSource = StyleKit.Icons.Unresolved,
                ActionMessage = "Start",
                ActionMessageFileSource = StyleKit.Icons.Share,
                RatingOfProduct = "3",
                CompanyName = "Golden Gate",
                Discount = "15% Discount",
                ContactNo = "000-555-1212",
                WebSiteURL = "www.domain.com",
            });

            Add(new Card()
            {
                TitleSource = "dishesfa.jpg",
                Status = CardStatus.Completed,
                Description = "Basics",
                DueDate = DateTime.Now.AddDays(-9),
                DirationInMinutes = 35,
                StatusMessage = "Assignment Completed",
                StatusMessageFileSource = StyleKit.Icons.Completed,
                ActionMessage = "Report",
                ActionMessageFileSource = StyleKit.Icons.Share,
                RatingOfProduct = "1",
                CompanyName = "Colosseum",
                Discount = "30% Discount",
                ContactNo = "000-555-1212",
                WebSiteURL = "www.domain.com",
            });


            Add(new Card()
            {
                TitleSource = "dishesfa.jpg",
                Status = CardStatus.Alert,
                Description = "Basics",
                DueDate = DateTime.Now.AddDays(-9),
                DirationInMinutes = 35,
                StatusMessage = "Assignment Completed",
                StatusMessageFileSource = StyleKit.Icons.Completed,
                ActionMessage = "Report",
                ActionMessageFileSource = StyleKit.Icons.Share,
                RatingOfProduct = "4",
                CompanyName = "Big Ben",
                Discount = "20% Discount",
                ContactNo = "000-555-1212",
                WebSiteURL = "www.domain.com",
            });
        }
    }
}