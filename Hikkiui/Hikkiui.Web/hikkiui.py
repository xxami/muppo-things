
import cherrypy
from core import app

if __name__ == '__main__':
    cherrypy.quickstart(app.Hikkiui())
