using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using BCLservice.ServiceData;

namespace BCLservice.ServiceModel
{
    [Route("/BuildingSelect")]
    public class BuildingSelect_Request : IReturn<BuildingResponse>
    {
    }

    public class BuildingResponse : IHasResponseStatus
    {
        private ResponseStatus _responseStatus;
        public ResponseStatus ResponseStatus
        {
            get
            {
                return _responseStatus;
            }
            set
            {
                _responseStatus = value;
            }
        }
        private List<BuildingObject> _Building;
        public List<BuildingObject> Building
        {
            get
            {
                return _Building;
            }
            set
            {
                _Building = value;
            }
        }
        public BuildingResponse()
        {
            this.Building = new List<BuildingObject>();
            this.ResponseStatus = new ResponseStatus();
            this.ResponseStatus.Errors = new List<ResponseError>();
        }
    }

    [Route("/jTable/BuildingSelect")]
    public class jBuildingSelect_Request : IReturn<jBuildingResponse>
    {
    }

    public class jBuildingResponse 
    {
        public string Result { get; set; }
        public List<BuildingObject> Records { get; set; }
        
        public void New()
        {
            this.Records = new List<BuildingObject>();
            this.Result = string.Empty;
        }
    }

}

