using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{    
    public interface IEventBus
    {    
        //T refers to any type of object (Generic); Restriction : it should be of the type "Command"
        //Wil be using MediatR library to send commands through the bus.
        Task SendCommand<T>(T command) where T : Command;

        //Publish any type of event; @event because reserved keyword has been used. Restriction : it should be of the type Event
        void Publish<T>(T @event) where T : Event;

        //Sevices can subscribe to different events
        void Subscribe<T, TH>() where T : Event
                                where TH : IEventHandler<T>;
    }
}
