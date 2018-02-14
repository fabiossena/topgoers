using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using TopGoers.ServiceModel.Interface;
using TopGoers.ServiceModel.Mockup;
using TopGoers.ServiceModel;

namespace TopGoers.ViewModel
{
    public class BaseViewModel
    {
        private bool useMockup = false;

        private IPlaceService placeService;
        private IStateService stateService;
        private ICityService cityService;
        
        public BaseViewModel()
        {
            this.useMockup = true;
        }

        public IPlaceService PlaceService
        {
            get
            {
                this.LoadPlaceService();
                return this.placeService;
            }
        }

        public IStateService StateService
        {
            get
            {
                this.LoadStateService();
                return this.stateService;
            }
        }

        public ICityService CityService
        {
            get
            {
                this.LoadCityService();
                return this.cityService;
            }
        }

        private void LoadStateService()
        {
            if (this.stateService == null)
            {
                if (useMockup)
                {
                    this.stateService = new StateMockup();
                }
                else
                {
                    this.stateService = new StateService();
                }
            }
        }

        private void LoadCityService()
        {
            if (this.cityService == null)
            {
                if (useMockup)
                {
                    this.cityService = new CityMockup();
                }
                else
                {
                    this.cityService = new CityService();
                }
            }
        }

        private void LoadPlaceService()
        {
            if (this.placeService == null)
            {
                if (useMockup)
                {
                    this.placeService = new PlaceMockup();
                }
                else
                {
                    this.placeService = new PlaceService();
                }
            }
        }
    }
}
