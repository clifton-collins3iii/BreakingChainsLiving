using BCLservice.ServiceData;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCLservice.ServiceData.BCLservice;
using BCLservice.ServiceData.Objects;
namespace BCLservice.ServiceModel
{
    internal class jTableOptions_Routes
    {
    }

    [Route("/jTableOptions/BuildingOptionsSelect")]
    public class jBuildingOptions_Request : IReturn<jBuildingOptionsResponse>
    {
    }

    public class jBuildingOptionsResponse
    {
        public string Result { get; set; }
        public List<BuildingOptionsObject> Options { get; set; }
        public string Message { get; set; }

        public void New()
        {
            this.Options = new List<BuildingOptionsObject>();
            this.Result = string.Empty;
            this.Message = string.Empty;
        }
    }

    [Route("/jTableOptions/StatesOptionsSelect")]
    public class jStatesOptions_Request : IReturn<jBuildingOptionsResponse>
    {
    }

    public class jTableOptionsResponse
    {
        public string Result { get; set; }
        public List<jTableOptionsObject> Options { get; set; }
        public string Message { get; set; }

        public void New()
        {
            this.Options = new List<jTableOptionsObject>();
            this.Result = string.Empty;
            this.Message = string.Empty;
        }
    }
}