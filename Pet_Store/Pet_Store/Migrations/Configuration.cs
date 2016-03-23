namespace Pet_Store.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Pet_Store.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<Pet_Store.Models.AnimalDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Pet_Store.Models.AnimalDBContext context)
        {
            var animal = new Animal()
            {
                AnimalID = 0,
                Name = "Cardinal",
                ShortDescription = "Cardinals, in the family Cardinalidae, are passerine birds found in North and South America." +
                    "They are also known as cardinal-grosbeaks and cardinal-buntings. The South American cardinals in the genus Paroaria are placed in another family," +
                    "the Thraupidae (previously placed in Emberizidae).",
                LongDescription = "They are robust, seed-eating birds with strong bills. The family ranges in size from the 12-cm (4.7-in), 11.5-g (0.40-oz) and up " +
                    "orange-breasted bunting to the 25-cm (9.8-in), 85-g (2.99-oz) black-headed saltator. They are typically associated with open woodland. The sexes " +
                    "usually have distinctive appearances. The northern cardinal type species was named by colonists for the male's red crest, reminiscent of a Catholic " +
                    "cardinal's biretta.",
                DateRecieved = DateTime.Now,
                Quantity = 5,
                Price = 74.95
            };
            context.Animals.Add(animal);
        }
    }
}
