"use strict";
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
exports.__esModule = true;
exports.parseToMessage = exports.parseToObject = void 0;
var client = __importStar(require("./js/client"));
var server = __importStar(require("./js/server"));
var authClient = __importStar(require("./js/auth-client"));
var authServer = __importStar(require("./js/auth-server"));
var mapClient = __importStar(require("./idmap/client.json"));
var mapServer = __importStar(require("./idmap/server.json"));
var mapAuthClient = __importStar(require("./idmap/auth-client.json"));
var mapAuthServer = __importStar(require("./idmap/auth-server.json"));
var revMapServer = {};
var revMapClient = {};
var revMapAuthServer = {};
var revMapAuthClient = {};
mapClient.forEach(function (x, i) { return (revMapClient[x] = i); });
mapServer.forEach(function (x, i) { return (revMapServer[x] = i); });
mapAuthClient.forEach(function (x, i) { return (revMapAuthClient[x] = i); });
mapAuthServer.forEach(function (x, i) { return (revMapAuthServer[x] = i); });
function parseToObject(pType, data) {
    var type = '';
    var packet;
    switch (pType) {
        case 'server':
            type = mapServer[data[0]];
            packet = server[type];
            break;
        case 'client':
            type = mapClient[data[0]];
            packet = client[type];
            break;
        case 'auth-server':
            type = mapAuthServer[data[0]];
            packet = authServer[type];
            break;
        case 'auth-client':
            type = mapAuthClient[data[0]];
            packet = authClient[type];
            break;
        default:
            return null;
    }
    if (type == undefined)
        return null;
    var rawData = data.slice(1);
    var message = packet.decode(rawData);
    var error = null;
    if (packet != undefined)
        error = packet.verify(message);
    else
        error = 'Invalid packet';
    if (error) {
        console.error('Invalid ' + pType + ' packet! Type: ' + type, error);
        return null;
    }
    return { data: packet.toObject(message, { defaults: true }), type: type };
}
exports.parseToObject = parseToObject;
function parseToMessage(pType, type, data) {
    var packet;
    var typeRaw = 0;
    if (pType == 'server') {
        if (typeRaw == undefined)
            return null;
        packet = server[type];
    }
    else {
        typeRaw = revMapClient[type];
        if (typeRaw == undefined)
            return null;
        packet = client[type];
        pType = 'client';
    }
    switch (pType) {
        case 'server':
            typeRaw = revMapServer[type];
            packet = server[type];
            break;
        case 'client':
            typeRaw = revMapClient[type];
            packet = client[type];
            break;
        case 'auth-server':
            typeRaw = revMapAuthServer[type];
            packet = authServer[type];
            break;
        case 'auth-client':
            typeRaw = revMapAuthClient[type];
            packet = authClient[type];
            break;
        default:
            return null;
    }
    var error = null;
    if (packet != undefined)
        error = packet.verify(data);
    else
        error = 'Invalid packet';
    if (error) {
        console.error('Invalid ' + pType + ' packet! Type: ' + type, data, error);
        return null;
    }
    var message = packet.create(data);
    var encoded = packet.encode(message).finish();
    var out = new Uint8Array(1 + encoded.length);
    out.set([typeRaw]);
    out.set(encoded, 1);
    return out.buffer;
}
exports.parseToMessage = parseToMessage;
