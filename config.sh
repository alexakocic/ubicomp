echo 'Sending Sensor Inputs to Orion...'

curl orion:1026/v2/entities -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
    "id": "sensor-input-1",
    "type": "SensorInput",
    "carbon_monoxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "latitude": {
        "type": "Float",
        "value": "43.320528",
        "metadata": {}
    },
    "longitude": {
        "type": "Float",
        "value": "21.894861",
        "metadata": {}
    },
    "nitrogen_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "ozone": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "particullate_matter": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "sulfure_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    }
}
EOF

curl orion:1026/v2/entities -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
    "id": "sensor-input-2",
    "type": "SensorInput",
    "carbon_monoxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "latitude": {
        "type": "Float",
        "value": "43.090528",
        "metadata": {}
    },
    "longitude": {
        "type": "Float",
        "value": "21.764861",
        "metadata": {}
    },
    "nitrogen_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "ozone": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "particullate_matter": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "sulfure_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    }
}
EOF

curl orion:1026/v2/entities -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
    "id": "sensor-input-3",
    "type": "SensorInput",
    "carbon_monoxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "latitude": {
        "type": "Float",
        "value": "43.315794",
        "metadata": {}
    },
    "longitude": {
        "type": "Float",
        "value": "21.883980",
        "metadata": {}
    },
    "nitrogen_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "ozone": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "particullate_matter": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "sulfure_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    }
}
EOF

curl orion:1026/v2/entities -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
    "id": "sensor-input-4",
    "type": "SensorInput",
    "carbon_monoxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "latitude": {
        "type": "Float",
        "value": "43.321757",
        "metadata": {}
    },
    "longitude": {
        "type": "Float",
        "value": "21.890697",
        "metadata": {}
    },
    "nitrogen_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "ozone": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "particullate_matter": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "sulfure_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    }
}
EOF

curl orion:1026/v2/entities -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
    "id": "sensor-input-5",
    "type": "SensorInput",
    "carbon_monoxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "latitude": {
        "type": "Float",
        "value": "43.315591",
        "metadata": {}
    },
    "longitude": {
        "type": "Float",
        "value": "21.908742",
        "metadata": {}
    },
    "nitrogen_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "ozone": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "particullate_matter": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "sulfure_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    }
}
EOF

curl orion:1026/v2/entities -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
    "id": "sensor-input-6",
    "type": "SensorInput",
    "carbon_monoxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "latitude": {
        "type": "Float",
        "value": "43.320914",
        "metadata": {}
    },
    "longitude": {
        "type": "Float",
        "value": "21.886941",
        "metadata": {}
    },
    "nitrogen_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "ozone": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "particullate_matter": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "sulfure_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    }
}
EOF

curl orion:1026/v2/entities -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
    "id": "sensor-input-7",
    "type": "SensorInput",
    "carbon_monoxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "latitude": {
        "type": "Float",
        "value": "43.332684",
        "metadata": {}
    },
    "longitude": {
        "type": "Float",
        "value": "21.870677",
        "metadata": {}
    },
    "nitrogen_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "ozone": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "particullate_matter": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "sulfure_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    }
}
EOF

curl orion:1026/v2/entities -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
    "id": "sensor-input-8",
    "type": "SensorInput",
    "carbon_monoxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "latitude": {
        "type": "Float",
        "value": "43.313499",
        "metadata": {}
    },
    "longitude": {
        "type": "Float",
        "value": "21.861943",
        "metadata": {}
    },
    "nitrogen_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "ozone": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "particullate_matter": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "sulfure_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    }
}
EOF

curl orion:1026/v2/entities -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
    "id": "sensor-input-9",
    "type": "SensorInput",
    "carbon_monoxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "latitude": {
        "type": "Float",
        "value": "43.323802",
        "metadata": {}
    },
    "longitude": {
        "type": "Float",
        "value": "21.862458",
        "metadata": {}
    },
    "nitrogen_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "ozone": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "particullate_matter": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "sulfure_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    }
}
EOF

curl orion:1026/v2/entities -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
    "id": "sensor-input-10",
    "type": "SensorInput",
    "carbon_monoxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "latitude": {
        "type": "Float",
        "value": "43.302912",
        "metadata": {}
    },
    "longitude": {
        "type": "Float",
        "value": "21.892027",
        "metadata": {}
    },
    "nitrogen_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "ozone": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "particullate_matter": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    },
    "sulfure_dioxide": {
        "type": "Float",
        "value": 0,
        "metadata": {}
    }
}
EOF

echo $'\nDone sending sensors to Orion'

echo $'\nAdding service to IDAS...'

curl idas:4041/iot/services -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
  "services": [
    {
      "apikey":      "sensorinputkey",
      "cbroker":     "http://172.17.0.4:1026",
      "entity_type": "SensorInput",
      "resource":    "/iot/d"
    }
  ]
}
EOF

echo $'Done adding service to IDAS'

echo $'\nAdding sensors to IDAS...'

curl idas:4041/iot/devices -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
"devices": [
    {
      "device_id":   "sensor-device-01",
      "entity_name": "sensor-input-1",
      "entity_type": "SensorInput",
      "attributes": [
        {
          "object_id": "o",
          "name":      "ozone",
          "type":      "Float"
        },
        {
          "object_id": "p",
          "name":      "particullate_matter",
          "type":      "Float"
        },
        {
          "object_id": "c",
          "name":      "carbon_monoxide",
          "type":      "Float"
        },
        {
          "object_id": "s",
          "name":      "sulfure_dioxide",
          "type":      "Float"
        },
        {
          "object_id": "n",
          "name":      "nitrogen_dioxide",
          "type":      "Float"
        }
      ],
      "static_attributes": []
    },
    {
      "device_id":   "sensor-device-02",
      "entity_name": "sensor-input-2",
      "entity_type": "SensorInput",
      "attributes": [
        {
          "object_id": "o",
          "name":      "ozone",
          "type":      "Float"
        },
        {
          "object_id": "p",
          "name":      "particullate_matter",
          "type":      "Float"
        },
        {
          "object_id": "c",
          "name":      "carbon_monoxide",
          "type":      "Float"
        },
        {
          "object_id": "s",
          "name":      "sulfure_dioxide",
          "type":      "Float"
        },
        {
          "object_id": "n",
          "name":      "nitrogen_dioxide",
          "type":      "Float"
        }
      ],
      "static_attributes": []
    },
    {
      "device_id":   "sensor-device-03",
      "entity_name": "sensor-input-3",
      "entity_type": "SensorInput",
      "attributes": [
        {
          "object_id": "o",
          "name":      "ozone",
          "type":      "Float"
        },
        {
          "object_id": "p",
          "name":      "particullate_matter",
          "type":      "Float"
        },
        {
          "object_id": "c",
          "name":      "carbon_monoxide",
          "type":      "Float"
        },
        {
          "object_id": "s",
          "name":      "sulfure_dioxide",
          "type":      "Float"
        },
        {
          "object_id": "n",
          "name":      "nitrogen_dioxide",
          "type":      "Float"
        }
      ],
      "static_attributes": []
    },
    {
      "device_id":   "sensor-device-04",
      "entity_name": "sensor-input-4",
      "entity_type": "SensorInput",
      "attributes": [
        {
          "object_id": "o",
          "name":      "ozone",
          "type":      "Float"
        },
        {
          "object_id": "p",
          "name":      "particullate_matter",
          "type":      "Float"
        },
        {
          "object_id": "c",
          "name":      "carbon_monoxide",
          "type":      "Float"
        },
        {
          "object_id": "s",
          "name":      "sulfure_dioxide",
          "type":      "Float"
        },
        {
          "object_id": "n",
          "name":      "nitrogen_dioxide",
          "type":      "Float"
        }
      ],
      "static_attributes": []
    },
    {
      "device_id":   "sensor-device-05",
      "entity_name": "sensor-input-5",
      "entity_type": "SensorInput",
      "attributes": [
        {
          "object_id": "o",
          "name":      "ozone",
          "type":      "Float"
        },
        {
          "object_id": "p",
          "name":      "particullate_matter",
          "type":      "Float"
        },
        {
          "object_id": "c",
          "name":      "carbon_monoxide",
          "type":      "Float"
        },
        {
          "object_id": "s",
          "name":      "sulfure_dioxide",
          "type":      "Float"
        },
        {
          "object_id": "n",
          "name":      "nitrogen_dioxide",
          "type":      "Float"
        }
      ],
      "static_attributes": []
    },
    {
      "device_id":   "sensor-device-06",
      "entity_name": "sensor-input-6",
      "entity_type": "SensorInput",
      "attributes": [
        {
          "object_id": "o",
          "name":      "ozone",
          "type":      "Float"
        },
        {
          "object_id": "p",
          "name":      "particullate_matter",
          "type":      "Float"
        },
        {
          "object_id": "c",
          "name":      "carbon_monoxide",
          "type":      "Float"
        },
        {
          "object_id": "s",
          "name":      "sulfure_dioxide",
          "type":      "Float"
        },
        {
          "object_id": "n",
          "name":      "nitrogen_dioxide",
          "type":      "Float"
        }
      ],
      "static_attributes": []
    },
    {
      "device_id":   "sensor-device-07",
      "entity_name": "sensor-input-7",
      "entity_type": "SensorInput",
      "attributes": [
        {
          "object_id": "o",
          "name":      "ozone",
          "type":      "Float"
        },
        {
          "object_id": "p",
          "name":      "particullate_matter",
          "type":      "Float"
        },
        {
          "object_id": "c",
          "name":      "carbon_monoxide",
          "type":      "Float"
        },
        {
          "object_id": "s",
          "name":      "sulfure_dioxide",
          "type":      "Float"
        },
        {
          "object_id": "n",
          "name":      "nitrogen_dioxide",
          "type":      "Float"
        }
      ],
      "static_attributes": []
    },
    {
      "device_id":   "sensor-device-08",
      "entity_name": "sensor-input-8",
      "entity_type": "SensorInput",
      "attributes": [
        {
          "object_id": "o",
          "name":      "ozone",
          "type":      "Float"
        },
        {
          "object_id": "p",
          "name":      "particullate_matter",
          "type":      "Float"
        },
        {
          "object_id": "c",
          "name":      "carbon_monoxide",
          "type":      "Float"
        },
        {
          "object_id": "s",
          "name":      "sulfure_dioxide",
          "type":      "Float"
        },
        {
          "object_id": "n",
          "name":      "nitrogen_dioxide",
          "type":      "Float"
        }
      ],
      "static_attributes": []
    },
    {
      "device_id":   "sensor-device-09",
      "entity_name": "sensor-input-9",
      "entity_type": "SensorInput",
      "attributes": [
        {
          "object_id": "o",
          "name":      "ozone",
          "type":      "Float"
        },
        {
          "object_id": "p",
          "name":      "particullate_matter",
          "type":      "Float"
        },
        {
          "object_id": "c",
          "name":      "carbon_monoxide",
          "type":      "Float"
        },
        {
          "object_id": "s",
          "name":      "sulfure_dioxide",
          "type":      "Float"
        },
        {
          "object_id": "n",
          "name":      "nitrogen_dioxide",
          "type":      "Float"
        }
      ],
      "static_attributes": []
    },
    {
      "device_id":   "sensor-device-10",
      "entity_name": "sensor-input-10",
      "entity_type": "SensorInput",
      "attributes": [
        {
          "object_id": "o",
          "name":      "ozone",
          "type":      "Float"
        },
        {
          "object_id": "p",
          "name":      "particullate_matter",
          "type":      "Float"
        },
        {
          "object_id": "c",
          "name":      "carbon_monoxide",
          "type":      "Float"
        },
        {
          "object_id": "s",
          "name":      "sulfure_dioxide",
          "type":      "Float"
        },
        {
          "object_id": "n",
          "name":      "nitrogen_dioxide",
          "type":      "Float"
        }
      ],
      "static_attributes": []
    }
  ]
}
EOF

echo $'\nDone adding sensors'

echo $'\nAdd orion subscription...'

curl orion:1026/v1/subscribeContext -s -S --header 'Content-Type: application/json' \
 --header 'Fiware-Service: ecocity' --header 'Fiware-ServicePath: /' -d @- <<EOF
{
    "entities": [
        {
            "type": "SensorInput",
            "isPattern": "false",
            "id": "sensor-input-1"
        },
        {
            "type": "SensorInput",
            "isPattern": "false",
            "id": "sensor-input-2"
        },        
        {
            "type": "SensorInput",
            "isPattern": "false",
            "id": "sensor-input-3"
        },
        {
            "type": "SensorInput",
            "isPattern": "false",
            "id": "sensor-input-4"
        },
        {
            "type": "SensorInput",
            "isPattern": "false",
            "id": "sensor-input-5"
        },
        {
            "type": "SensorInput",
            "isPattern": "false",
            "id": "sensor-input-6"
        },
        {
            "type": "SensorInput",
            "isPattern": "false",
            "id": "sensor-input-7"
        },
        {
            "type": "SensorInput",
            "isPattern": "false",
            "id": "sensor-input-8"
        },
        {
            "type": "SensorInput",
            "isPattern": "false",
            "id": "sensor-input-9"
        },
        {
            "type": "SensorInput",
            "isPattern": "false",
            "id": "sensor-input-10"
        }
    ],
    "attributes": [
        "carbon_monoxide",
        "nitrogen_dioxide",
        "ozone",
        "particullate_matter",
        "sulfure_dioxide"
    ],
    "reference": "http://172.17.0.5:5050/notify",
    "duration": "P1M",
    "notifyConditions": [
        {
            "type": "ONCHANGE",
            "condValues": [
		        "carbon_monoxide",
		        "nitrogen_dioxide",
		        "ozone",
		        "particullate_matter",
		        "sulfure_dioxide"
            ]
        }
    ],
    "throttling": "PT1S"
}
EOF

echo $'\nDone adding Orion subscription'