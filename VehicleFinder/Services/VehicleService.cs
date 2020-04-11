namespace VehicleFinder.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VehicleFinder.Data;
    using VehicleFinder.Models;
    using VehicleFinder.Models.Enums;
    using VehicleFinder.ViewModels;

    public sealed class VehicleService
    {
        public bool AddVehicle(AddVehicleViewModel viewModel)
        {
            var brand = getOrCreateBrand(viewModel.Brand);
            var model = getOrCreateModel(viewModel.Model, viewModel.ModelYear);

            try
            {
                using (var db = new AppDbContext())
                {
                    var vehicle = new Vehicle()
                    {
                        Brand = db.Brands.Attach(brand),
                        Model = db.Models.Attach(model),
                        ManufactureYear = viewModel.ManufactureYear,
                        BodyStyle = getBodyStyle(viewModel.BodyStyle),
                        HorsePower = viewModel.HorsePower,
                        Engine = db.Engines.Attach(getOrCreateEngine(viewModel.EngineName, getEngineType(viewModel.EngineType))),
                        Extras = getExtras(viewModel).Select(e => db.Extras.Attach(e)).ToList()
                    };

                    db.Vehicles.Add(vehicle);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private ICollection<Extra> getExtras(AddVehicleViewModel viewModel)
        {
            var availableExtras = new List<Extra>();
            var extras = new List<Extra>();

            using (var db = new AppDbContext())
            {
                availableExtras = db.Extras.ToList();
            }
           
            if (viewModel.HasDashcam)
                extras.Add(availableExtras.First(e => e.Name.CompareTo("Dashcam") == 0));
            if(viewModel.HasHeatedSeats)
                extras.Add(availableExtras.First(e => e.Name.CompareTo("Heated Seats") == 0));
            if(viewModel.HasLeatherUpholstery)
                extras.Add(availableExtras.First(e => e.Name.CompareTo("Leather Upholstery") == 0));
            if(viewModel.HasNavigation)
                extras.Add(availableExtras.First(e => e.Name.CompareTo("Navigation") == 0));
            if(viewModel.HasPanoramicRoof)
                extras.Add(availableExtras.First(e => e.Name.CompareTo("Panoramic Roof") == 0));
            if(viewModel.HasReversingCamera)
                extras.Add(availableExtras.First(e => e.Name.CompareTo("Reversing Camera") == 0));

            return extras;
        }

        private EngineType getEngineType(string engineType)
        { 
            switch (engineType)
            {
                case "Invariant":
                    return EngineType.Invariant;
                case "Petrol":
                    return EngineType.Petrol;
                case "Gas":
                    return EngineType.Gas;
                case "Electric":
                    return EngineType.Electric;
                case "Hybrid":
                    return EngineType.Hybrid;
                case "PetrolAndGas":
                    return EngineType.PetrolAndGas;
                default:
                    return EngineType.Invariant;
            }
        }

        private Engine getOrCreateEngine(string engineName, EngineType engineType)
        {
            Engine engine;

            using (var db = new AppDbContext())
            {
                engine = db.Engines.FirstOrDefault(e=>e.Name.CompareTo(engineName)==0 && e.EngineType == engineType);
                if (engine == null)
                {
                    engine = new Engine() { Name = engineName, EngineType = engineType };
                    db.Engines.Add(engine);
                    db.SaveChanges();
                }
            }

            return engine;
        }

        private BodyStyle getBodyStyle(string bodyStyle)
        {
            switch (bodyStyle) 
            {
                case "Cabriolet":
                    return BodyStyle.Cabriolet;
                case "Coupe":
                    return BodyStyle.Coupe;
                case "Hatchback":
                    return BodyStyle.Hatchback;
                case "Kombi":
                    return BodyStyle.Kombi;
                case "Minivan":
                    return BodyStyle.Minivan;
                case "Sedan":
                    return BodyStyle.Sedan;
                default:
                    return BodyStyle.Invariant;
            }
        }

        private Model getOrCreateModel(string modelName, int modelYear)
        {
            Model model;

            using (var db = new AppDbContext())
            {
                model = db.Models.FirstOrDefault(m=>m.Name.CompareTo(modelName)==0 && m.Year==modelYear);
                if (model == null)
                {
                    model = new Model() { Name = modelName, Year=modelYear };
                    db.Models.Add(model);
                    db.SaveChanges();
                }
            }

            return model;
        }

        private Brand getOrCreateBrand(string brandName)
        {
            Brand brand;

            using (var db = new AppDbContext()) 
            {
                brand = db.Brands.FirstOrDefault(b => b.Name.CompareTo(brandName) == 0);
                if (brand == null)
                {
                    brand = new Brand() { Name = brandName };
                    db.Brands.Add(brand);
                    db.SaveChanges();
                }
            }

            return brand;
        }
    }
}
