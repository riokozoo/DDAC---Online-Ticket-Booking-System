namespace OnlineTicket.Migrations
{
    using OnlineTicket.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineTicket.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OnlineTicket.Models.ApplicationDbContext context)
        {

            var usr = new List<User>
            {
                new User() {Email = "rio_alfiando@yahoo.com", FirstName = "Rio", LastName = "Alfiando", DateOfBirth = "11/04/1992", Password = "rioal", ConfirmPassword = "rioal"}
            };
            context.SaveChanges();

            var cfl = new List<CargoFlight>
            {
                new CargoFlight() {airLine = "Ukraine International Airlines", airCraft = "Boeing737", source = "Kuala Lumpur", destination = "Jakarta", date = "20 November 2017", capacity = 100 },
                new CargoFlight() {airLine = "Ukraine International Airlines", airCraft = "Boeing737", source = "Hamburg", destination = "New York", date = "21 November 2017", capacity = 100 },
                new CargoFlight() {airLine = "Ukraine International Airlines", airCraft = "Boeing737", source = "United Kingdom", destination = "France", date = "22 November 2017", capacity = 100 },
                new CargoFlight() {airLine = "Ukraine International Airlines", airCraft = "Boeing737", source = "Moscow", destination = "Brazil", date = "23 November 2017", capacity = 100 },
                new CargoFlight() {airLine = "Ukraine International Airlines", airCraft = "Airbus", source = "Pochinki", destination = "China", date = "24 November 2017", capacity = 100 },
                new CargoFlight() {airLine = "Ukraine International Airlines", airCraft = "Airbus", source = "Polyana", destination = "Thailand", date = "25 November 2017", capacity = 100 },
                new CargoFlight() {airLine = "Ukraine International Airlines", airCraft = "Airbus", source = "Turkey", destination = "Moroco", date = "26 November 2017", capacity = 100 },
            };
            cfl.ForEach(e => context.cargo.AddOrUpdate(p => p.CFID, e));
            context.SaveChanges();

            var pfl = new List<PassengerFlight>
            {
                new PassengerFlight() {airLine = "Ukraine International Airlines", airCraft = "Boeing737", source = "Turkey", destination = "Jakarta", date = "20 November 2017"},
                new PassengerFlight() {airLine = "Ukraine International Airlines", airCraft = "Boeing737", source = "Polyana", destination = "New York", date = "21 November 2017"},
                new PassengerFlight() {airLine = "Ukraine International Airlines", airCraft = "Boeing737", source = "Pochinki", destination = "France", date = "22 November 2017"},
                new PassengerFlight() {airLine = "Ukraine International Airlines", airCraft = "Boeing737", source = "Moscow", destination = "Brazil", date = "23 November 2017"},
                new PassengerFlight() {airLine = "Ukraine International Airlines", airCraft = "Airbus", source = "United Kingdom", destination = "China", date = "24 November 2017"},
                new PassengerFlight() {airLine = "Ukraine International Airlines", airCraft = "Airbus", source = "Hamburg", destination = "Thailand", date = "25 November 2017"},
                new PassengerFlight() {airLine = "Ukraine International Airlines", airCraft = "Airbus", source = "Kuala Lumpur", destination = "Moroco", date = "26 November 2017"},
            };
            pfl.ForEach(e => context.passenger.AddOrUpdate(p => p.PFID, e));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
