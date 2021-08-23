using Funcional.Tech.Api.Dto;
using System;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Funcional.Tech.Api.Services
{
    public class ContaAddedService
    {
        private readonly ISubject<ContaAddedMensage> _messageStream = new ReplaySubject<ContaAddedMensage>(1);
        public ContaAddedMensage AddContaAddedMessage(ContaAddedMensage message)
        {
            _messageStream.OnNext(message);
            return message;
        }
    }
}
