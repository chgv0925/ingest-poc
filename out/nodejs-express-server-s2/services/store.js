/* eslint-disable no-unused-vars */
const Service = require('./Service');

class StoreService {

  static eventStore() {
    let ret = [
      {
        "_id": "uniqueEventId1",
        "_rev": "1-..",
        "type": "event",
        "name": "Event 1",
        "start": "2000-01-01T20:00:00.00Z",
        "end": "2000-01-01T22:00:00.00Z",
        "source": {
          "channel": "8dde15c4-ca1b-4872-8082-58bfad889daa/London-MDI-1/London-SUM-1/C1,channel/summit",
          "routerSource": "https://.."
        },
        "classification": [
          {
            "Sport": "57:Tennis"
          },
          {
            "Competition": "1230:Gran Slam"
          },
          {
            "Event": "520:French Open"
          },
          {
            "Round": "1:"
          },
          {
            "Disciplin": "2:"
          },
          {
            "Gender": "57:Tennis"
          },
          {
            "Sport": "57:Tennis"
          }
        ],
        "seriesId": "seriesId",
        "series": {
          "_id": "seriesId",
          "_rev": "1-..",
          "type": "series",
          "start": "2000-01-01T20:00:00.00Z",
          "end": "2000-01-01T22:00:00.00Z",
          "repeat": "EveryDay",
          "endBy": "2000-01-02"
        },
        "status": "Ready"
      },
      {
        "_id": "uniqueEventId2",
        "_rev": "1-..",
        "type": "event",
        "name": "Event 1",
        "start": "2000-01-01T20:00:00.00Z",
        "end": "2000-01-01T22:00:00.00Z",
        "source": {
          "channel": "66037096-dbb8-4836-85db-9c0661a4b094/Paris-MDI-1/Paris-SUM-1/C1,channel/summit",
          "routerSource": "https://.."
        },
        "classification": [
          {
            "Sport": "57:Tennis"
          },
          {
            "Competition": "1230:Gran Slam"
          },
          {
            "Event": "520:French Open"
          },
          {
            "Round": "1:"
          },
          {
            "Disciplin": "2:"
          },
          {
            "Gender": "57:Tennis"
          },
          {
            "Sport": "57:Tennis"
          }
        ],
        "seriesId": "seriesId",
        "series": {
          "_id": "seriesId",
          "_rev": "1-..",
          "type": "series",
          "start": "2000-01-01T20:00:00.00Z",
          "end": "2000-01-01T22:00:00.00Z",
          "repeat": "EveryDay",
          "endBy": "2000-01-02"
        },
        "status": "Ready"
      },
      {
        "_id": "uniqueEventId3",
        "_rev": "1-..",
        "type": "event",
        "name": "Event 2",
        "start": "2000-01-02T20:00:00.00Z",
        "end": "2000-01-02T22:00:00.00Z",
        "source": {
          "channel": "8dde15c4-ca1b-4872-8082-58bfad889daa/London-MDI-1/London-SUM-1/C1,channel/summit",
          "routerSource": "https://.."
        },
        "classification": [
          {
            "Sport": "57:Tennis"
          },
          {
            "Competition": "1230:Gran Slam"
          },
          {
            "Event": "520:French Open"
          },
          {
            "Round": "1:"
          },
          {
            "Disciplin": "2:"
          },
          {
            "Gender": "57:Tennis"
          },
          {
            "Sport": "57:Tennis"
          }
        ],
        "seriesId": "seriesId",
        "series": {
          "_id": "seriesId",
          "_rev": "1-..",
          "type": "series",
          "start": "2000-01-01T20:00:00.00Z",
          "end": "2000-01-01T22:00:00.00Z",
          "repeat": "EveryDay",
          "endBy": "2000-01-02"
        },
        "status": "Ready"
      },
      {
        "_id": "uniqueEventId4",
        "_rev": "1-..",
        "type": "event",
        "name": "Event 2",
        "start": "2000-01-02T20:00:00.00Z",
        "end": "2000-01-02T22:00:00.00Z",
        "source": {
          "channel": "66037096-dbb8-4836-85db-9c0661a4b094/Paris-MDI-1/Paris-SUM-1/C1,channel/summit",
          "routerSource": "https://.."
        },
        "classification": [
          {
            "Sport": "57:Tennis"
          },
          {
            "Competition": "1230:Gran Slam"
          },
          {
            "Event": "520:French Open"
          },
          {
            "Round": "1:"
          },
          {
            "Disciplin": "2:"
          },
          {
            "Gender": "57:Tennis"
          },
          {
            "Sport": "57:Tennis"
          }
        ],
        "seriesId": "seriesId",
        "series": {
          "_id": "seriesId",
          "_rev": "1-..",
          "type": "series",
          "start": "2000-01-01T20:00:00.00Z",
          "end": "2000-01-01T22:00:00.00Z",
          "repeat": "EveryDay",
          "endBy": "2000-01-02"
        },
        "status": "Ready"
      }
    ];
    return ret;
  } 

}

module.exports = StoreService;
