var mqtt = require("aws-iot-device-sdk");
/**
 * Publishing Device
 */
var pubDevice = mqtt.device({
  keyPath: "./76348a68a9-private.pem.key",
  certPath: "./76348a68a9-certificate.pem.crt",
  caPath: "./Rootca.pem",
  clientId: "test",
  host: "a3ieilx72a5bln-ats.iot.us-west-1.amazonaws.com"
});

pubDevice.on("connect", function() {
  console.log("connect");
  pubDevice.publish("bvc", JSON.stringify({ status: 1 }));
});

pubDevice.on("message", function(topic, payload) {
  console.log("message", topic, payload.toString());
  console.log("Sent");
});
