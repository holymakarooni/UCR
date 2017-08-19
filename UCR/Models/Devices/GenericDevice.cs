﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Providers;
using UCR.Models.Mapping;

namespace UCR.Models.Devices
{
    public sealed class GenericDevice : Device
    {
        public GenericDevice() : base(DeviceType.Mouse)
        {
        }

        public override bool AddDeviceBinding(DeviceBinding deviceBinding)
        {
            throw new NotImplementedException();
        }

        public override void ClearSubscribers()
        {
            throw new NotImplementedException();
        }

        public override void SubscribeDeviceBindings(UCRContext ctx)
        {
            throw new NotImplementedException();
        }

        public override void SubscribeDeviceBindingInput(UCRContext ctx, DeviceBinding deviceBinding)
        {
            throw new NotImplementedException();
        }

        protected override InputType MapDeviceBindingInputType(DeviceBinding deviceBinding)
        {
            throw new NotImplementedException();
        }
    }
}
