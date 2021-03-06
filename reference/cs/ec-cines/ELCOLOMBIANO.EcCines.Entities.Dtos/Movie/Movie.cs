﻿/*==========================================================================*/
/* Source File:   MOVIE.CS                                                  */
/* Description:   A movie detailed information for JSON serialization       */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Feb.11/2015                                               */
/* Last Modified: Mar.11/2015                                               */
/* Version:       1.3                                                       */
/* Copyright (c), 2015 Arkix, El Colombiano                                 */
/*==========================================================================*/

/*===========================================================================
History
Feb.11/2015 COQ File created.
============================================================================*/
using System;
using System.Collections.Generic;

namespace ELCOLOMBIANO.EcCines.Entities.Dtos.Movie {
    /// <summary>
    /// A movie detailed information for JSON serialization
    /// </summary>
    public class Movie {
        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public string url { get; set; }
        public string active { get; set; }
        public int idGenre { get; set; }
        public string genre { get; set; }
        public List<MovieLocation> locations { get; set; }
    }
}
