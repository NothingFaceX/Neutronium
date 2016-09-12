﻿using System.Threading.Tasks;
using Neutronium.Core.JavascriptEngine.JavascriptObject;

namespace Neutronium.Core.JavascriptUIFramework
{
    /// <summary>
    /// Abstraction of the javascript framework responsible for databind
    /// and change tracking
    /// </summary>
    public interface IJavascriptSessionInjector
    {
        /// <summary>
        /// Maps a simple javascript object to an observable javascript object
        /// </summary>
        /// <param name="rawObject">
        /// Simple javascript to be mapped
        /// </param>
        /// <param name="mapper">
        /// Mapper to be used to map the original object and the observable one
        /// </param>
        /// <returns>
        /// the corresponding observable javascript object
        ///</returns>
        IJavascriptObject Inject(IJavascriptObject rawObject, IJavascriptObjectMapper mapper);


        /// <summary>
        /// Register main view model in javascript windows
        /// </summary>
        /// <param name="jsObject">
        /// Main ViewModel: javascript Observable object 
        /// </param>
        /// <returns>
        /// task that completes when all binding are done
        ///</returns>
        Task RegisterMainViewModel(IJavascriptObject jsObject);
    }
}
