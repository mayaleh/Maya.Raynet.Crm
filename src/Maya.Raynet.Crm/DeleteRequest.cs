﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Raynet.Crm
{
    public class DeleteRequest
    {
        protected virtual List<string> Actions { get; set; }

        protected internal async Task<Model.DataResult<TResponse>> ExecuteAsync<TReqeustBody, TResponse>(ApiClient apiClient, TReqeustBody body)
        {
            throw new NotImplementedException();
        }
    }
}
