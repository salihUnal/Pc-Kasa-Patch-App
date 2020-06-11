using System;

namespace PcKasaBatchUygulaması
{
    internal class ManagementClass : IDisposable
    {
        private string v;

        public ManagementClass(string v)
        {
            this.v = v;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}