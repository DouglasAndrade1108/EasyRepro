using System;

namespace Teste
{
    internal class XrmBrowser : IDisposable
    {
        private object options;

        public XrmBrowser(object options)
        {
            this.options = options;
        }

        public object CommandBar { get; internal set; }
        public object Grid { get; internal set; }
        public object Entity { get; internal set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}