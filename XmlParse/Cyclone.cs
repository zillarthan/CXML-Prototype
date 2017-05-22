using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlParse
{
    public class Header
    {
        public string Product { get; set; }
        public string TrackingDomain { get; set; }
        public string MoreInfo { get; set; }
        public string MoreMetadata { get; set; }
        public string BaseTime { get; set; }
        public string CreationTime { get; set; }
        public string SpatialReferenceSystem { get; set; }

        public class GeneratingApplication
        {
            public GeneratingApplication(string applicationType)
            {
                ApplicationType = applicationType;
            }

            public string ApplicationType { get; set; }
        }

        public Header(string product, string trackingDomain, string moreInfo, string moreMetadata, string baseTime, string creationTime, string spatialReferenceSystem)
        {
            //All placeholder values, replace with xml reading.
            string applicationType = string.Empty;
            string ensembleNumMembers = string.Empty;
            string ensemblePertubationMethod = string.Empty;
            string productionCentreValue = string.Empty;
            string productionCentresubCentre = string.Empty;
            Product = product;
            TrackingDomain = trackingDomain;
            MoreInfo = moreInfo;
            MoreMetadata = moreMetadata;
            BaseTime = baseTime;
            CreationTime = creationTime;
            SpatialReferenceSystem = spatialReferenceSystem;

            Model model = new Model("string", "string", "string", "string");
            Ensemble ensemble = new Ensemble(ensembleNumMembers, ensemblePertubationMethod);
            ProductionCenter productioncenter = new ProductionCenter(productionCentreValue, productionCentresubCentre);
            GeneratingApplication generatingApplication = new GeneratingApplication(applicationType)
            {
                ApplicationType = applicationType
            };
        }
    }

    public class Model
    {
        public Model(string name, string domain, string modelResolution, string productionStatus)
        {
            Name = name;
            Domain = domain;
            ModelResolution = modelResolution;
            ProductionStatus = productionStatus;
            string dataResolutionUnits = string.Empty;
            string dataResolutionValue = string.Empty;
            DataResolution DataRes = new DataResolution(dataResolutionUnits, dataResolutionValue)
            {
                Units = dataResolutionUnits,
                Value = dataResolutionValue
            };
        }

        public string Name { get; set; }
        public string Domain { get; set; }
        public string ModelResolution { get; set; }
        public string ProductionStatus { get; set; }
    }

    public class DataResolution
    {
        public string Units;
        public string Value;

        public DataResolution(string units, string value)
        {
            Units = units;
            Value = value;
        }
    }

    public class Ensemble
    {
        public string NumMembers;
        public string PertubationMethod;

        public Ensemble(string numMembers, string pertubationMethod)
        {
            NumMembers = numMembers;
            PertubationMethod = pertubationMethod;
        }
    }

    public class ProductionCenter
    {
        public string Value;
        public string SubCenter;

        public ProductionCenter(string value, string subCenter)
        {
            Value = value;
            SubCenter = subCenter;
        }
    }

    public class Latitude
    {
        public string Units { get; set; }
        public string Precision { get; set; }
        public string Value { get; set; }
    }

    public class Longitude
    {
        public string Units { get; set; }
        public string Precision { get; set; }
        public string Value { get; set; }
    }

    public class Accuracy
    {
        public string Units { get; set; }
        public string Value { get; set; }
    }

    public class Disturbance
    {
        public string ID;
        public string CycloneName;
        public string CycloneNumber;
        public string LocalID;
        public string Basin;
        public string ObjectiveTechnique;

        public Disturbance(string cycloneName, string cycloneNumber, string localID, string basin, string objectiveTechnique)
        {
            CycloneName = cycloneName;
            CycloneNumber = cycloneNumber;
            LocalID = localID;
            Basin = basin;
            ObjectiveTechnique = objectiveTechnique;

            string fixhour = string.Empty;
            string fixsource = string.Empty;
            string fixvalidTime = string.Empty;
            string fixmissionNumber = string.Empty;
            string fixsubRegion = string.Empty;
            string fixpositionCodeNumber = string.Empty;
            string fixsatelliteName = string.Empty;
            string fixsatelliteSensor = string.Empty;
            string fixSite = string.Empty;
            string fixplatform = string.Empty;
            string fixradoBcode = string.Empty;
            Latitude fixLatitude = new Latitude
            {
                Precision = string.Empty,
                Units = string.Empty,
                Value = string.Empty
            };
            Longitude fixLongitude = new Longitude
            {
                Precision = string.Empty,
                Units = string.Empty,
                Value = string.Empty
            };
            Accuracy fixAccuracy = new Accuracy()
            {
                Units = string.Empty,
                Value = string.Empty
            };

            Fix disturbanceFix = new Fix(fixhour, fixsource, fixvalidTime, fixmissionNumber, fixsource, fixpositionCodeNumber, fixsatelliteName, fixsatelliteSensor, fixSite, fixplatform, fixradoBcode, fixLatitude, fixLongitude, fixAccuracy);
        }

        
    }

    public class FlightLevel
    {
        public string Units;
        public string Precision;
        public string Value;

        public FlightLevel(string units, string precision, string value)
        {
            Units = units;
            Precision = precision;
            Value = value;
        }
    }

    public class NavAccuracy
    {
        private string units;
        private string value;

        public NavAccuracy(string units, string value)
        {
            this.units = units;
            this.value = value;
        }
    }

    public class RadarSitePosition
    {
        public string wmoIdentifier;

        public RadarSitePosition(string wmoIdentifier, Latitude latitude, Longitude longitude)
        {
            this.wmoIdentifier = wmoIdentifier;
            Latitude = latitude;
            Longitude = longitude;
        }

        public Latitude Latitude { get; set; }
        public Longitude Longitude { get; set; }
    }

    public class DistanceToNearestData
    {
        private string units;
        private string value;

        public DistanceToNearestData(string units, string value)
        {
            this.units = units;
            this.value = value;
        }
    }


    public class Fix
    {
        public string Hour;
        public string Source;
        public string ValidTime;
        public string MissionNumber;
        public string SubRegion;
        public string PositionCodeNumber;
        public string SatelliteName;
        public string SatelliteSensor;
        public string FixSite;
        public string Platform;
        public string RadoBcode;
        public Latitude Latitude { get; set; }
        public Longitude Longitude { get; set; }
        public Accuracy Accuracy { get; set; }
        
        public FlightLevel Flightlevel { get; set; }
        public NavAccuracy Navaccuracy { get; set; }
        public RadarSitePosition Radarsiteposition { get; set; }
        public DistanceToNearestData Distancetonearestdata { get; set; }

        public Fix(string hour, string source,
            string validTime, string missionNumber,
            string subRegion, string positionCodeNumber,
            string satelliteName, string satelliteSensor,
            string fixSite, string platform, string radoBcode,
            Latitude latitude, Longitude longitude, Accuracy accuracy)
        {
            Hour = hour;
            Source = source;
            ValidTime = validTime;
            MissionNumber = missionNumber;
            SubRegion = subRegion;
            PositionCodeNumber = positionCodeNumber;
            SatelliteName = satelliteName;
            SatelliteSensor = satelliteSensor;
            FixSite = fixSite;
            Platform = platform;
            RadoBcode = radoBcode;
            Latitude = latitude;
            Longitude = longitude;
            Accuracy = accuracy;
        }

    }

    private class CycloneData
    {
        private string development;
        private string category;
        private string comments;
        private string systemDepth;
        private string biasCorrected;
        private class CyclonePhase
        {
            private struct StormRelThkSymetry
            {
                private string units;
                private string value;

            }
            private struct ThermalWindLower
            {
                private string units;
                private string value;
            }
            private struct ThermalWindUpper
            {
                private string units;
                private string value;
            }
        }
        private class LastClosedIsobar
        {
            private struct Pressure
            {
                private string units;
                private string precision;
                private string value;
            }
            private struct Radius
            {
                private string units;
                private string precision;
                private string value;
            }
        }
        private class WindContours
        {
            private string source;
            private struct WindSpeed
            {
                private string units;
                private string value;
                private struct Radius
                {
                    private string sector;
                    private string units;
                    private string value;
                }
            }
        }
        private class MaximumPrecipitation
        {
            private string source;
            private struct Intensity
            {
                private string units;
                private string precision;
                private string value;
            }
            private struct Accuracy
            {
                private string units;
                private string precision;
                private string value;
            }
            private struct Latitude
            {
                private string units;
                private string precision;
                private string value;
            }
            private struct Longitude
            {
                private string units;
                private string precision;
                private string value;
            }
            private string precipitationType;
        }
        private class MaximumWaveHeight
        {
            private struct Height
            {
                private string units;
                private string precision;
                private string value;
            }
            private struct Accuracy
            {
                private string units;
                private string precision;
                private string value;
            }
            private struct Latitude
            {
                private string units;
                private string precision;
                private string value;
            }
            private struct Longitude
            {
                private string units;
                private string precision;
                private string value;
            }
        }
        private class SeaContours
        {
            private string source;
            private struct WaveHeight
            {
                private string units;
                private string value;
                private struct Radius
                {
                    private string sector;
                    private string units;
                    private string value;
                }
            }
        }
        private class FixedRadii
        {
            private string source;
            private struct FixedRadius
            {
                private string units;
                private string value;
                private struct Pressure
                {
                    private string units;
                    private string value;
                }
                private struct TangentialWind
                {
                    private string units;
                    private string precision;
                    private string value;
                }
            }
        }
        private class Dvorak
        {
            private string dataTNumber;
            private string modelExpectedTNumber;
            private string patternTNumber;
            private string finalTNumber;
            private string ongoingChange;
            private string currentIntensity;
            private string pastChange;
            private struct ChangePeriod
            {
                private string units;
                private string value;
            }
        }
        private class Eye
        {
            private string source;
            private string shape;
            private struct Diameter
            {
                private string units;
                private string precision;
                private string value;
            }
            private class ShortAxis
            {
                private string units;
                private string precision;
                private string value;
            }
            private class WallCloudThickness
            {
                private string units;
                private string value;
            }
            private string percentWallObserved;
        }
        private class StormMotion
        {
            private string source;
            private struct DirectionToward
            {
                private string units;
                private string precision;
                private string value;
            }
            private struct Speed
            {
                private string units;
                private string precision;
                private string value;
            }
            private struct SpeedAccuracy
            {
                private string units;
                private string value;
            }
            private struct DirectionAccuracy
            {
                private string units;
                private string value;
            }
        }
        private class MinimumPressure
        {
            private string source;
            private class Pressure
            {
                private string units;
                private string precision;
                private string value;
            }
            private class Accuracy
            {
                private string units;
                private string value;
            }
        }
    }

    public class MaximumWind
    {
        private string source;
        public Latitude Latitude { get; set; }
        public Longitude Longitude { get; set; }

        public Speed Speed { get; set; }
        public AveragingPeriod AveragingPeriod { get; set; }
        public Radius Radius { get; set; }
        public Gusts Gusts { get; set; }
        public GustAvgPeriod GustAvgPeriod { get; set; }
        public Accuracy Accuracy { get; set; }
        public Bearing Bearing { get; set; }
        public Range Range { get; set; }
    }


    public class Speed
    {
        private string units;
        private string prevision;
        private string value;
    }
    public class AveragingPeriod
    {
        private string units;
        private string value;
    }

    public class Radius
    {
        private string units;
        private string value;
    }

    public class Gusts
    {
        private string units;
        private string precision;
        private string value;
    }

    public class GustAvgPeriod
    {
        private string units;
        private string value;
    }

    public class Accuracy
    {
        private string units;
        private string value;
    }

    public class Bearing
    {
        private string units;
        private string precision;
        private string value;
    }

    public class Range
    {
        private string units;
        private string precision;
        private string value;
    }

    public class Temperature
    {
        public class TempInsideEye
            private string units;
            private string value;
        }

        public class TempOutsideEye
        {
            private string units;
            private string value;
        }
    }


    public struct DewPointTemperature
    {
        private string units;
        private string value;
    }


    private struct SeaSurfaceTemperature
    {
        private string units;
        private string value;
    }


    private class SpiralOverlay
    {
        private string units;
        private string value;
    }


    class DataType
    {
        public string datatype;
        public string member;
        public string origin;
        public string perturb;
        public string type;
        public Disturbance Disturbance { get; set; }
        public DataType(string datatype, string member, string origin, string perturb, string type)
        {
            this.datatype = datatype;
            this.member = member;
            this.origin = origin;
            this.perturb = perturb;
            this.type = type;

            string disturbanceID = string.Empty;
            string disturbanceCycloneName = string.Empty;
            string distrubanceCycloneNumber = string.Empty;
            string distrubanceLocalID = string.Empty;
            string distrubanceBasin = string.Empty;
            string distrubanceObjectiveTechnique = string.Empty;

            Disturbance disturbance = new Disturbance(disturbanceCycloneName, distrubanceCycloneNumber, distrubanceLocalID, distrubanceBasin, distrubanceObjectiveTechnique);

        }        
    }
}