//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bcc.Auth.Stores.Raven
//{
//    public class RavenSession : IAsyncDisposable, IDisposable
//    {
//        public RavenStore(RavenStore store)
//        {

//        }

//        protected virtual Task DisposeAsyncCore()
//        {
            
//        }

//        public virtual void Dispose(bool disposing)
//        {
            
//        }

//        public async ValueTask DisposeAsync()
//        {
//            // Perform async cleanup.
//            await DisposeAsyncCore();

//            // Dispose of unmanaged resources.
//            Dispose(false);

//#pragma warning disable CA1816 // Dispose methods should call SuppressFinalize
//            // Suppress finalization.
//            GC.SuppressFinalize(this);
//#pragma warning restore CA1816 // Dispose methods should call SuppressFinalize
//        }
//    }
//}
