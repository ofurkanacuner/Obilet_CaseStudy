using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Obilet_CaseStudy.Models;
using Obilet_CaseStudy.Models.Request;
using Obilet_CaseStudy.Models.Response;
using Obilet_CaseStudy.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Obilet_CaseStudy.Controllers
{
    public class HomeController : Controller
    {
        #region - Variable

        private readonly ISessionService _sessionService;
        private readonly IBusLocationsService _busLocationsService;
        private readonly IBusJourneysService _busJourneysService;

        #endregion

        #region - Ctor

        public HomeController(ISessionService sessionService,
            IBusLocationsService busLocationsService,
            IBusJourneysService busJourneysService)
        {
            _sessionService = sessionService;
            _busLocationsService = busLocationsService;
            _busJourneysService = busJourneysService;
        }

        #endregion

        public async Task<IActionResult> Index()
        {
            var getSessionResponse = await _sessionService.GetSession();
            var getSessionResult = JsonConvert.DeserializeObject<GetSessionResponse>(getSessionResponse.Data).Data;

            var getBusLocationResponse = await _busLocationsService.GetBusLocations(getSessionResult.SessionId, getSessionResult.DeviceId);
            var getBusLocationResult = JsonConvert.DeserializeObject<BaseResponse<GetBusLocationsResponse>>(getBusLocationResponse.Data).Data;
            TempData["GetBusLocationsResponse"] = getBusLocationResult;
            return View(new BusJourneysRequest());
        }

        public async Task<IActionResult> JourneyPost(BusJourneysRequest model)
        {
            var getSessionResponse = await _sessionService.GetSession();
            var getSessionResult = JsonConvert.DeserializeObject<GetSessionResponse>(getSessionResponse.Data).Data;

            var getBusJourneysResponse = await _busJourneysService.GetBusJourneys(getSessionResult.SessionId, getSessionResult.DeviceId, model);
            if(JsonConvert.DeserializeObject<BaseResponse<BusJourneysResponse>>(getBusJourneysResponse.Data).Status != "Success")
            {
                TempData["Message"] = JsonConvert.DeserializeObject<BaseResponse<BusJourneysResponse>>(getBusJourneysResponse.Data).UserMessage;
                return View(new List<BusJourneysResponse>());
            }

            var getBusJourneysResult = JsonConvert.DeserializeObject<BaseResponse<BusJourneysResponse>>(getBusJourneysResponse.Data).Data;
            TempData["Message"] = null;
            return View(getBusJourneysResult);
        }
    }
}
