/*
 * Swagger Eventstore
 *
 * A sample API that uses a eventstore as an example to demonstrate features in the OpenAPI 3.0 specification
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Org.OpenAPITools.Attributes;
using Microsoft.AspNetCore.Authorization;
using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DefaultApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Creates a new event in the store.  Duplicates are allowed</remarks>
        /// <param name="createEventDto">Event to add to the store</param>
        /// <response code="201">event response</response>
        /// <response code="0">unexpected error</response>
        [HttpPost]
        [Route("/ingest/v2/events")]
        [ValidateModelState]
        [SwaggerOperation("AddEvent")]
        [SwaggerResponse(statusCode: 201, type: typeof(Event), description: "event response")]
        [SwaggerResponse(statusCode: 0, type: typeof(Error), description: "unexpected error")]
        public virtual IActionResult AddEvent([FromBody]CreateEventDto createEventDto)
        { 

            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(Event));
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Error));
            string exampleJson = null;
            exampleJson = "null";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Event>(exampleJson)
            : default(Event);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>deletes a single event based on the ID supplied</remarks>
        /// <param name="id">ID of event to delete</param>
        /// <response code="204">event deleted</response>
        /// <response code="0">unexpected error</response>
        [HttpDelete]
        [Route("/ingest/v2/events/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteEvent")]
        [SwaggerResponse(statusCode: 0, type: typeof(Error), description: "unexpected error")]
        public virtual IActionResult DeleteEvent([FromRoute][Required]long id)
        { 

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Error));

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Returns a user based on a single ID, if the user does not have access to the event</remarks>
        /// <param name="id">ID of event to fetch</param>
        /// <response code="200">event response</response>
        /// <response code="0">unexpected error</response>
        [HttpGet]
        [Route("/ingest/v2/events/{id}")]
        [ValidateModelState]
        [SwaggerOperation("FindEventById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Event), description: "event response")]
        [SwaggerResponse(statusCode: 0, type: typeof(Error), description: "unexpected error")]
        public virtual IActionResult FindEventById([FromRoute][Required]long id)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Event));
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Error));
            string exampleJson = null;
            exampleJson = "null";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Event>(exampleJson)
            : default(Event);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Returns all events from the system that the user has access to. </remarks>
        /// <param name="tags">tags to filter by</param>
        /// <param name="limit">maximum number of results to return</param>
        /// <response code="200">event response</response>
        /// <response code="0">unexpected error</response>
        [HttpGet]
        [Route("/ingest/v2/events")]
        [ValidateModelState]
        [SwaggerOperation("FindEvents")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Event>), description: "event response")]
        [SwaggerResponse(statusCode: 0, type: typeof(Error), description: "unexpected error")]
        public virtual IActionResult FindEvents([FromQuery]List<string> tags, [FromQuery]int limit)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Event>));
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Error));
            string exampleJson = null;
            exampleJson = "null";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Event>>(exampleJson)
            : default(List<Event>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
