using System;
using System.Collections.Generic;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Store_Manager.Data;
using Store_Manager.Models;
namespace Store_Manager.Seeds
{
    public class ProductSeeder
    {
        private readonly MyDbContext _context;

        public ProductSeeder(MyDbContext context)
        {
            _context = context;
        }

        public void SeedProducts()
        {
            //only populates the product table if it is empty
            if (!_context.product.Any())
            {
                //JSON data
                var productsJson = @"
        [
             {
        ""name"": ""hammer"",
        ""description"": ""Iron head with wooden grasp"",
        ""price"": 21.50,
        ""stockquantity"": 52
    },
    {
        ""name"": ""screwdriver"",
        ""description"": ""Phillips head screwdriver"",
        ""price"": 5.99,
        ""stockquantity"": 30
    },
    {
        ""name"": ""wrench"",
        ""description"": ""Adjustable wrench"",
        ""price"": 9.99,
        ""stockquantity"": 25
    },
    {
        ""name"": ""pliers"",
        ""description"": ""Long-nose pliers"",
        ""price"": 7.49,
        ""stockquantity"": 20
    },
    {
        ""name"": ""tape measure"",
        ""description"": ""25-foot tape measure"",
        ""price"": 12.99,
        ""stockquantity"": 15
    },
    {
        ""name"": ""hammer drill"",
        ""description"": ""Corded hammer drill"",
        ""price"": 89.99,
        ""stockquantity"": 10
    },
    {
        ""name"": ""circular saw"",
        ""description"": ""7.25-inch circular saw"",
        ""price"": 79.99,
        ""stockquantity"": 12
    },
    {
        ""name"": ""safety goggles"",
        ""description"": ""Protective safety goggles"",
        ""price"": 4.99,
        ""stockquantity"": 50
    },
    {
        ""name"": ""work gloves"",
        ""description"": ""Heavy-duty work gloves"",
        ""price"": 6.99,
        ""stockquantity"": 40
    },
    {
        ""name"": ""nails"",
        ""description"": ""Assorted nails (1 lb)"",
        ""price"": 3.49,
        ""stockquantity"": 100
    },
    {
        ""name"": ""screws"",
        ""description"": ""Assorted screws (1 lb)"",
        ""price"": 2.99,
        ""stockquantity"": 120
    },
    {
        ""name"": ""level"",
        ""description"": ""24-inch spirit level"",
        ""price"": 8.99,
        ""stockquantity"": 18
    },
    {
        ""name"": ""utility knife"",
        ""description"": ""Retractable utility knife"",
        ""price"": 4.49,
        ""stockquantity"": 22
    },
    {
        ""name"": ""safety helmet"",
        ""description"": ""Hard hat safety helmet"",
        ""price"": 14.99,
        ""stockquantity"": 10
    },
    {
        ""name"": ""pliers set"",
        ""description"": ""Set of three pliers"",
        ""price"": 19.99,
        ""stockquantity"": 8
    },
    {
        ""name"": ""paint roller"",
        ""description"": ""9-inch paint roller"",
        ""price"": 6.79,
        ""stockquantity"": 15
    },
    {
        ""name"": ""paintbrush set"",
        ""description"": ""Set of five paintbrushes"",
        ""price"": 8.99,
        ""stockquantity"": 20
    },
    {
        ""name"": ""wood glue"",
        ""description"": ""Wood adhesive glue"",
        ""price"": 5.29,
        ""stockquantity"": 30
    },
    {
        ""name"": ""hacksaw"",
        ""description"": ""Metal hacksaw"",
        ""price"": 11.49,
        ""stockquantity"": 12
    },
    {
        ""name"": ""pliers set"",
        ""description"": ""Set of three pliers"",
        ""price"": 19.99,
        ""stockquantity"": 8
    },
    {
        ""name"": ""screwdriver set"",
        ""description"": ""Set of six screwdrivers"",
        ""price"": 12.99,
        ""stockquantity"": 15
    },
    {
        ""name"": ""hex key set"",
        ""description"": ""Set of 10 hex keys"",
        ""price"": 6.49,
        ""stockquantity"": 20
    },
    {
        ""name"": ""measuring tape"",
        ""description"": ""12-foot measuring tape"",
        ""price"": 4.99,
        ""stockquantity"": 25
    },
    {
        ""name"": ""safety vest"",
        ""description"": ""High-visibility safety vest"",
        ""price"": 8.99,
        ""stockquantity"": 30
    },
    {
        ""name"": ""cordless drill"",
        ""description"": ""18V cordless drill"",
        ""price"": 69.99,
        ""stockquantity"": 10
    },
    {
        ""name"": ""extension cord"",
        ""description"": ""25-foot extension cord"",
        ""price"": 13.49,
        ""stockquantity"": 20
    },
    {
        ""name"": ""wood screws"",
        ""description"": ""Assorted wood screws (1 lb)"",
        ""price"": 3.99,
        ""stockquantity"": 80
    },
    {
        ""name"": ""caulk gun"",
        ""description"": ""Heavy-duty caulk gun"",
        ""price"": 7.99,
        ""stockquantity"": 15
    },
    {
        ""name"": ""paint tray"",
        ""description"": ""9-inch paint tray"",
        ""price"": 2.99,
        ""stockquantity"": 25
    },
{
        ""name"": ""drill bits set"",
        ""description"": ""Assorted drill bits (10-pack)"",
        ""price"": 14.99,
        ""stockquantity"": 25
    },
    {
        ""name"": ""crescent wrench"",
        ""description"": ""Adjustable crescent wrench"",
        ""price"": 10.79,
        ""stockquantity"": 18
    },
    {
        ""name"": ""wood chisel set"",
        ""description"": ""Set of three wood chisels"",
        ""price"": 11.99,
        ""stockquantity"": 15
    },
    {
        ""name"": ""sawhorse pair"",
        ""description"": ""Foldable sawhorse pair"",
        ""price"": 29.99,
        ""stockquantity"": 10
    },
    {
        ""name"": ""level"",
        ""description"": ""48-inch spirit level"",
        ""price"": 16.99,
        ""stockquantity"": 12
    },
    {
        ""name"": ""paint sprayer"",
        ""description"": ""Electric paint sprayer"",
        ""price"": 49.99,
        ""stockquantity"": 8
    },
    {
        ""name"": ""wood stain"",
        ""description"": ""Wood stain (1 quart)"",
        ""price"": 7.49,
        ""stockquantity"": 20
    },
    {
        ""name"": ""safety harness"",
        ""description"": ""Full-body safety harness"",
        ""price"": 34.99,
        ""stockquantity"": 10
    },
    {
        ""name"": ""angle grinder"",
        ""description"": ""4.5-inch angle grinder"",
        ""price"": 37.99,
        ""stockquantity"": 15
    },
    {
        ""name"": ""extension ladder"",
        ""description"": ""20-foot extension ladder"",
        ""price"": 149.99,
        ""stockquantity"": 5
    },
    {
        ""name"": ""sledgehammer"",
        ""description"": ""16-pound sledgehammer"",
        ""price"": 29.99,
        ""stockquantity"": 8
    },
    {
        ""name"": ""concrete nails"",
        ""description"": ""Concrete nails (1 lb)"",
        ""price"": 4.29,
        ""stockquantity"": 30
    },
    {
        ""name"": ""staple gun"",
        ""description"": ""Heavy-duty staple gun"",
        ""price"": 18.99,
        ""stockquantity"": 12
    },
    {
        ""name"": ""caulking gun"",
        ""description"": ""Dripless caulking gun"",
        ""price"": 9.99,
        ""stockquantity"": 20
    },
    {
        ""name"": ""carpenter's square"",
        ""description"": ""12-inch carpenter's square"",
        ""price"": 6.99,
        ""stockquantity"": 25
    },
    {
        ""name"": ""pipe wrench"",
        ""description"": ""18-inch pipe wrench"",
        ""price"": 13.79,
        ""stockquantity"": 10
    },
    {
        ""name"": ""safety cones"",
        ""description"": ""Set of 6 safety cones"",
        ""price"": 15.99,
        ""stockquantity"": 15
    },
    {
        ""name"": ""bolt cutters"",
        ""description"": ""24-inch bolt cutters"",
        ""price"": 24.99,
        ""stockquantity"": 8
    },
    {
        ""name"": ""tarpaulin"",
        ""description"": ""10x12 ft. waterproof tarpaulin"",
        ""price"": 8.49,
        ""stockquantity"": 20
    },
    {
        ""name"": ""flashlight"",
        ""description"": ""LED flashlight with batteries"",
        ""price"": 7.99,
        ""stockquantity"": 25
    }
        ]";

                // Deserialize the JSON data into a list of Product objects
                var products = JsonSerializer.Deserialize<List<Product>>(productsJson);

                //go through the product 
                foreach (var product in products)
                {
                    _context.product.Add(product);
                }

                // Save changes to the database
                _context.SaveChanges();
            }
        }
    }
}
