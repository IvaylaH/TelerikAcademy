/*globals document, window, console*/

var CanvasDrawer = (function () {
    var ctx;
    function CanvasDrawer(canvasId){
        var canvas = document.querySelector(canvasId);
        ctx = canvas.getContext('2d');

        this.stroke = '#000';
        this.fill = 'yellowgreen';
        this.line = 1;
    }

    CanvasDrawer.prototype.drawRect = function (rect) {
        setContextSettings.call(this);

        ctx.fillRect(rect.x, rect.y, rect.width, rect.height);
        ctx.strokeRect(rect.x, rect.y, rect.width, rect.height);
    };

    CanvasDrawer.prototype.drawCircle = function (circle) {
        ctx.beginPath();
        setContextSettings.call(this);
        ctx.arc(circle.x, circle.y, circle.radius, 0, 2 * Math.PI);
        ctx.closePath();
        ctx.fill();
        ctx.stroke();
    };

    CanvasDrawer.prototype.drawLine = function (line) {
        ctx.beginPath();
        setContextSettings.call(this);
        ctx.moveTo(line.x1, line.y1);
        ctx.lineTo(line.x2, line.y2);
        ctx.closePath();
        ctx.stroke();
    };

    function setContextSettings() {
        ctx.fillStyle = this.fill;
        ctx.strokeStyle = this.stroke;
        ctx.lineWidth = this.line;
    }

    return CanvasDrawer;
}());

var Shapes = function () {
    var Rect,
        Circle,
        Line;

    Rect = function Rect(x, y, width, height) {
        if (!(this instanceof arguments.callee)) {
            return new Rect(x, y, width, height);
        }

        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    };

    Circle = function Circle(x, y, radius) {
        if (!(this instanceof arguments.callee)) {
            return new Circle(x, y, radius);
        }

        this.x = x;
        this.y = y;
        this.radius = radius;
    };

    Line = function Line(x1, y1, x2, y2) {
        if (!(this instanceof arguments.callee)) {
            return new Line(x1, y1, x2, y2);
        }

        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    };

    return {
        Rect: Rect,
        Circle: Circle,
        Line: Line
    };
};