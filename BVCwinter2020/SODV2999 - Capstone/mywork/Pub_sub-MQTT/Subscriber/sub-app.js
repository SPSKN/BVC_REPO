var mqtt = require("aws-iot-device-sdk");
/**
 * Subscribing Device
 */

var subDevice = mqtt.device({
  keyPath: "./76348a68a9-private.pem.key",
  certPath: "./76348a68a9-certificate.pem.crt",
  caPath: "./Rootca.pem",
  clientId: "test",
  host: "a3ieilx72a5bln-ats.iot.us-west-1.amazonaws.com"
});
/**
 * turn ON device
 * todo error handling
 * todo topics
 */
subDevice.on("connect", function() {
  //subDevice.publish("bvc", JSON.stringify({ status: 1}));
  console.log("connect"); 
  subDevice.subscribe("bvc");
  //subDevice.publish("bvc1", JSON.stringify({ temp: 32}));
});

subDevice.on("message", function(topic, payload) {
  console.log("message", topic, payload.toString());
});
