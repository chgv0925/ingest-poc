/* eslint-disable no-unused-vars */
const Service = require('./Service');
const StoreService = require('./store');

class IngestEventsService {

  /**
   * Add new event(s) to the store
   *
   * body List Event object that needs to be added to the store
   * returns List
   **/
  static addEvent({ body }) {
    return new Promise(
      async (resolve) => {
        try {
          resolve(Service.successResponse(''));
        } catch (e) {
          resolve(Service.rejectResponse(
            e.message || 'Invalid input',
            e.status || 405,
          ));
        }
      },
    );
  }

  /**
   * Remove an event from the store
   *
   * eventId String Event id to delete
   * no response value expected for this operation
   **/
  static deleteEventById({ eventId }) {
    return new Promise(
      async (resolve) => {
        try {
          resolve(Service.successResponse(''));
        } catch (e) {
          resolve(Service.rejectResponse(
            e.message || 'Invalid input',
            e.status || 405,
          ));
        }
      },
    );
  }

  /**
   * Remove event(s) from the store
   *
   * body EventDeleteDto Event object that needs to be deleted from the store
   * no response value expected for this operation
   **/
  static deleteEvents({ body }) {
    return new Promise(
      async (resolve) => {
        try {
          resolve(Service.successResponse(''));
        } catch (e) {
          resolve(Service.rejectResponse(
            e.message || 'Invalid input',
            e.status || 405,
          ));
        }
      },
    );
  }

  /**
   * Find an event by ID from the store
   * Returns a single event
   *
   * eventId String ID of event to return
   * returns Event
   **/
  static getEventById({ eventId }) {
    return new Promise(
      async (resolve) => {
        try {
          resolve(Service.successResponse(StoreService.eventStore().find(p => p._id == eventId)));
        } catch (e) {
          resolve(Service.rejectResponse(
            e.message || 'Invalid input',
            e.status || 405,
          ));
        }
      },
    );
  }

  /**
   * Find event(s) from the store
   * Returns a collection of events
   *
   * returns List
   **/
  static getEvents() {
    return new Promise(
      async (resolve) => {
        try {
          resolve(Service.successResponse(StoreService.eventStore()));
        } catch (e) {
          resolve(Service.rejectResponse(
            e.message || 'Invalid input',
            e.status || 405,
          ));
        }
      },
    );
  }

  /**
   * Modify an event in the store with form data
   *
   * eventId String ID of event that needs to be updated
   * returns Event
   **/
  static updateEventById({ eventId }) {
    return new Promise(
      async (resolve) => {
        try {
          resolve(Service.successResponse(''));
        } catch (e) {
          resolve(Service.rejectResponse(
            e.message || 'Invalid input',
            e.status || 405,
          ));
        }
      },
    );
  }

  /**
   * Modify event(s) in the store with form data
   *
   * events List 
   * series SeriesModel  (optional)
   * returns List
   **/
  static updateEvents({ events, series }) {
    return new Promise(
      async (resolve) => {
        try {
          resolve(Service.successResponse(''));
        } catch (e) {
          resolve(Service.rejectResponse(
            e.message || 'Invalid input',
            e.status || 405,
          ));
        }
      },
    );
  }

  /**
   * Modify an event status in the store
   *
   * eventId String ID of event that status needs to be updated
   * status String Status of event to be updated
   * no response value expected for this operation
   **/
  static updateStatusById({ eventId, status }) {
    return new Promise(
      async (resolve) => {
        try {
          resolve(Service.successResponse(''));
        } catch (e) {
          resolve(Service.rejectResponse(
            e.message || 'Invalid input',
            e.status || 405,
          ));
        }
      },
    );
  }

}

module.exports = IngestEventsService;
