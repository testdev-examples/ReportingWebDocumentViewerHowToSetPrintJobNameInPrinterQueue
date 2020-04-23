using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dxExampleWebDocViewerChangeJobPrintName {
    public static class HttpContext {
        private static Microsoft.AspNetCore.Http.IHttpContextAccessor m_httpContextAccessor;
        public static void Configure(Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor) {
            m_httpContextAccessor = httpContextAccessor;
        }
        public static Microsoft.AspNetCore.Http.HttpContext Current {
            get {
                return m_httpContextAccessor.HttpContext;
            }
        }


    }
}
