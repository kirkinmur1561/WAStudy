using System.Collections.Generic;

namespace WAStudy.Models.m1
{
    public static class CollectionGR
    {
        private static readonly List<GuestResponse> _guestResponses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> GuestResponses => _guestResponses;

        public static void AddResponse(GuestResponse gr) =>
            _guestResponses.Add(gr);
    }
}