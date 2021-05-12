﻿namespace Application.Common.Models
{
    public record CQRSResponse
    {
        public bool IsSuccessful { get; set; } = true;
        public string[] Errors { get; init; }

        public static CQRSResponse Fail(string[] errors)
            => new()
            {
                IsSuccessful = false,
                Errors = errors
            };

        public static CQRSResponse Fail(string error)
            => new()
            {
                IsSuccessful = false,
                Errors = new string[] { error }
            };
    }
}
