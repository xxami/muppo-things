
import cherrypy

class Hikkiui:

    @cherrypy.expose
    def index(self):
        return "Hello, world!"
