using System;

namespace UeMR.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);
    }
}
