﻿namespace Maya.Raynet.Crm.Model
{
    /// <summary>
    /// Max list size is 1000 items
    /// </summary>
    public class Pagination
    {
        public int? Limit { get; set; }
        public int? Offset { get; set; }
    }
}
