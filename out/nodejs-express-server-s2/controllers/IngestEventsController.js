const Controller = require('./Controller');

class IngestEventsController {
  constructor(Service) {
    this.service = Service;
  }

  async addEvent(request, response) {
    await Controller.handleRequest(request, response, this.service.addEvent);
  }

  async deleteEventById(request, response) {
    await Controller.handleRequest(request, response, this.service.deleteEventById);
  }

  async deleteEvents(request, response) {
    await Controller.handleRequest(request, response, this.service.deleteEvents);
  }

  async getEventById(request, response) {
    await Controller.handleRequest(request, response, this.service.getEventById);
  }

  async getEvents(request, response) {
    await Controller.handleRequest(request, response, this.service.getEvents);
  }

  async updateEventById(request, response) {
    await Controller.handleRequest(request, response, this.service.updateEventById);
  }

  async updateEvents(request, response) {
    await Controller.handleRequest(request, response, this.service.updateEvents);
  }

  async updateStatusById(request, response) {
    await Controller.handleRequest(request, response, this.service.updateStatusById);
  }

}

module.exports = IngestEventsController;
