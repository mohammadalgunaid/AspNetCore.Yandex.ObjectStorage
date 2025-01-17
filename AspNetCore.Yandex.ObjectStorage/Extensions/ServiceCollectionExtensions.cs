﻿using System;
using AspNetCore.Yandex.ObjectStorage.Configuration;
using AspNetCore.Yandex.ObjectStorage.Object;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCore.Yandex.ObjectStorage.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddYandexObjectStorage(this IServiceCollection services, Action<YandexStorageOptions> setupAction)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (setupAction == null) throw new ArgumentNullException(nameof(setupAction));

            services.Configure(setupAction);
            services.AddSingleton<YandexStorageService>();
        }

        public static void AddYandexObjectStorage(this IServiceCollection services, IConfiguration configuration, string sectionName = YandexConfigurationDefaults.DefaultSectionName)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            services.LoadYandexStorageOptions(configuration, sectionName)
                .AddSingleton<IYandexStorageService, YandexStorageService>();
        }
    }
}