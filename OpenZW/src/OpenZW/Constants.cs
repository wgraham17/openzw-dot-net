using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenZW
{
    public class Constants
    {
        public const int MaxTries = 1;  // set this to one, as I believe now that a ACK failure is indication that the device is offline, hence additional attempts will not work.
        public const int MaxRetries = 7;    // Don't exceed this retry limit
        public const int AcknowledgeTimeout = 1000;	// How long to wait for an ACK
        public const int ByteTimeout = 150;
        public const int RetryTimeoutMs = 10000;
        public const byte SOF = 0x01;
        public const byte ACK = 0x06;
        public const byte NAK = 0x15;
        public const byte CAN = 0x18;
        public const int NumberOfNodeBitfieldBytes = 29; // 29 bytes = 232 bits, one for each possible node in the network.

        public const byte REQUEST = 0x00;
        public const byte RESPONSE = 0x01;
        public const byte ZW_CLOCK_SET = 0x30;

        public const byte TRANSMIT_OPTION_ACK = 0x01;
        public const byte TRANSMIT_OPTION_LOW_POWER = 0x02;
        public const byte TRANSMIT_OPTION_AUTO_ROUTE = 0x04;
        public const byte TRANSMIT_OPTION_NO_ROUTE = 0x10;
        public const byte TRANSMIT_OPTION_EXPLORE = 0x20;

        public const byte TRANSMIT_COMPLETE_OK = 0x00;
        public const byte TRANSMIT_COMPLETE_NO_ACK = 0x01;
        public const byte TRANSMIT_COMPLETE_FAIL = 0x02;
        public const byte TRANSMIT_COMPLETE_NOT_IDLE = 0x03;
        public const byte TRANSMIT_COMPLETE_NOROUTE = 0x04;

        public const byte RECEIVE_STATUS_ROUTED_BUSY = 0x01;
        public const byte RECEIVE_STATUS_TYPE_BROAD = 0x04;

        public const byte FUNC_ID_SERIAL_API_GET_INIT_DATA = 0x02;
        public const byte FUNC_ID_SERIAL_API_APPL_NODE_INFORMATION = 0x03;
        public const byte FUNC_ID_APPLICATION_COMMAND_HANDLER = 0x04;
        public const byte FUNC_ID_ZW_GET_CONTROLLER_CAPABILITIES = 0x05;
        public const byte FUNC_ID_SERIAL_API_SET_TIMEOUTS = 0x06;
        public const byte FUNC_ID_SERIAL_API_GET_CAPABILITIES = 0x07;
        public const byte FUNC_ID_SERIAL_API_SOFT_RESET = 0x08;

        public const byte FUNC_ID_ZW_SEND_NODE_INFORMATION = 0x12;
        public const byte FUNC_ID_ZW_SEND_DATA = 0x13;
        public const byte FUNC_ID_ZW_GET_VERSION = 0x15;
        public const byte FUNC_ID_ZW_R_F_POWER_LEVEL_SET = 0x17;
        public const byte FUNC_ID_ZW_GET_RANDOM = 0x1c;
        public const byte FUNC_ID_ZW_MEMORY_GET_ID = 0x20;
        public const byte FUNC_ID_MEMORY_GET_BYTE = 0x21;
        public const byte FUNC_ID_ZW_READ_MEMORY = 0x23;

        public const byte FUNC_ID_ZW_SET_LEARN_NODE_STATE = 0x40;   // Not implemented;
        public const byte FUNC_ID_ZW_GET_NODE_PROTOCOL_INFO = 0x41; // Get protocol info (baud rate, listening, etc.) for a given node;
        public const byte FUNC_ID_ZW_SET_DEFAULT = 0x42;    // Reset controller and node info to default (original) values;
        public const byte FUNC_ID_ZW_NEW_CONTROLLER = 0x43; // Not implemented;
        public const byte FUNC_ID_ZW_REPLICATION_COMMAND_COMPLETE = 0x44;   // Replication send data complete;
        public const byte FUNC_ID_ZW_REPLICATION_SEND_DATA = 0x45;  // Replication send data;
        public const byte FUNC_ID_ZW_ASSIGN_RETURN_ROUTE = 0x46;    // Assign a return route from the specified node to the controller;
        public const byte FUNC_ID_ZW_DELETE_RETURN_ROUTE = 0x47;    // Delete all return routes from the specified node;
        public const byte FUNC_ID_ZW_REQUEST_NODE_NEIGHBOR_UPDATE = 0x48;   // Ask the specified node to update its neighbors (then read them from the controller);
        public const byte FUNC_ID_ZW_APPLICATION_UPDATE = 0x49; // Get a list of supported (and controller) command classes;
        public const byte FUNC_ID_ZW_ADD_NODE_TO_NETWORK = 0x4a;    // Control the addnode (or addcontroller) process...start, stop, etc.;
        public const byte FUNC_ID_ZW_REMOVE_NODE_FROM_NETWORK = 0x4b;   // Control the removenode (or removecontroller) process...start, stop, etc.;
        public const byte FUNC_ID_ZW_CREATE_NEW_PRIMARY = 0x4c; // Control the createnewprimary process...start, stop, etc.;
        public const byte FUNC_ID_ZW_CONTROLLER_CHANGE = 0x4d;  // Control the transferprimary process...start, stop, etc.;
        public const byte FUNC_ID_ZW_SET_LEARN_MODE = 0x50; // Put a controller into learn mode for replication/ receipt of configuration info;
        public const byte FUNC_ID_ZW_ASSIGN_SUC_RETURN_ROUTE = 0x51;    // Assign a return route to the SUC;
        public const byte FUNC_ID_ZW_ENABLE_SUC = 0x52; // Make a controller a Static Update Controller;
        public const byte FUNC_ID_ZW_REQUEST_NETWORK_UPDATE = 0x53; // Network update for a SUC(?);
        public const byte FUNC_ID_ZW_SET_SUC_NODE_ID = 0x54;    // Identify a Static Update Controller node id;
        public const byte FUNC_ID_ZW_DELETE_SUC_RETURN_ROUTE = 0x55;    // Remove return routes to the SUC;
        public const byte FUNC_ID_ZW_GET_SUC_NODE_ID = 0x56;    // Try to retrieve a Static Update Controller node id (zero if no SUC present);
        public const byte FUNC_ID_ZW_REQUEST_NODE_NEIGHBOR_UPDATE_OPTIONS = 0x5a;   // Allow options for request node neighbor update;
        public const byte FUNC_ID_ZW_EXPLORE_REQUEST_INCLUSION = 0x5e;  // supports NWI;
        public const byte FUNC_ID_ZW_REQUEST_NODE_INFO = 0x60;  // Get info (supported command classes) for the specified node;
        public const byte FUNC_ID_ZW_REMOVE_FAILED_NODE_ID = 0x61;  // Mark a specified node id as failed;
        public const byte FUNC_ID_ZW_IS_FAILED_NODE_ID = 0x62;  // Check to see if a specified node has failed;
        public const byte FUNC_ID_ZW_REPLACE_FAILED_NODE = 0x63;    // Remove a failed node from the controller's list (?);
        public const byte FUNC_ID_ZW_GET_ROUTING_INFO = 0x80;   // Get a specified node's neighbor information from the controller;
        public const byte FUNC_ID_SERIAL_API_SLAVE_NODE_INFO = 0xA0;    // Set application virtual slave node information;
        public const byte FUNC_ID_APPLICATION_SLAVE_COMMAND_HANDLER = 0xA1; // Slave command handler;
        public const byte FUNC_ID_ZW_SEND_SLAVE_NODE_INFO = 0xA2;   // Send a slave node information frame;
        public const byte FUNC_ID_ZW_SEND_SLAVE_DATA = 0xA3;    // Send data from slave;
        public const byte FUNC_ID_ZW_SET_SLAVE_LEARN_MODE = 0xA4;   // Enter slave learn mode;
        public const byte FUNC_ID_ZW_GET_VIRTUAL_NODES = 0xA5;  // Return all virtual nodes;
        public const byte FUNC_ID_ZW_IS_VIRTUAL_NODE = 0xA6;    // Virtual node test;
        public const byte FUNC_ID_ZW_SET_PROMISCUOUS_MODE = 0xD0;   // Set controller into promiscuous mode to listen to all frames;
        public const byte FUNC_ID_PROMISCUOUS_APPLICATION_COMMAND_HANDLER = 0xD1;

        public const byte ADD_NODE_ANY = 0x01;
        public const byte ADD_NODE_CONTROLLER = 0x02;
        public const byte ADD_NODE_SLAVE = 0x03;
        public const byte ADD_NODE_EXISTING = 0x04;
        public const byte ADD_NODE_STOP = 0x05;
        public const byte ADD_NODE_STOP_FAILED = 0x06;

        public const byte ADD_NODE_STATUS_LEARN_READY = 0x01;
        public const byte ADD_NODE_STATUS_NODE_FOUND = 0x02;
        public const byte ADD_NODE_STATUS_ADDING_SLAVE = 0x03;
        public const byte ADD_NODE_STATUS_ADDING_CONTROLLER = 0x04;
        public const byte ADD_NODE_STATUS_PROTOCOL_DONE = 0x05;
        public const byte ADD_NODE_STATUS_DONE = 0x06;
        public const byte ADD_NODE_STATUS_FAILED = 0x07;

        public const byte REMOVE_NODE_ANY = 0x01;
        public const byte REMOVE_NODE_CONTROLLER = 0x02;
        public const byte REMOVE_NODE_SLAVE = 0x03;
        public const byte REMOVE_NODE_STOP = 0x05;

        public const byte REMOVE_NODE_STATUS_LEARN_READY = 0x01;
        public const byte REMOVE_NODE_STATUS_NODE_FOUND = 0x02;
        public const byte REMOVE_NODE_STATUS_REMOVING_SLAVE = 0x03;
        public const byte REMOVE_NODE_STATUS_REMOVING_CONTROLLER = 0x04;
        public const byte REMOVE_NODE_STATUS_DONE = 0x06;
        public const byte REMOVE_NODE_STATUS_FAILED = 0x07;

        public const byte CREATE_PRIMARY_START = 0x02;
        public const byte CREATE_PRIMARY_STOP = 0x05;
        public const byte CREATE_PRIMARY_STOP_FAILED = 0x06;

        public const byte CONTROLLER_CHANGE_START = 0x02;
        public const byte CONTROLLER_CHANGE_STOP = 0x05;
        public const byte CONTROLLER_CHANGE_STOP_FAILED = 0x06;

        public const byte LEARN_MODE_STARTED = 0x01;
        public const byte LEARN_MODE_DONE = 0x06;
        public const byte LEARN_MODE_FAILED = 0x07;
        public const byte LEARN_MODE_DELETED = 0x80;

        public const byte REQUEST_NEIGHBOR_UPDATE_STARTED = 0x21;
        public const byte REQUEST_NEIGHBOR_UPDATE_DONE = 0x22;
        public const byte REQUEST_NEIGHBOR_UPDATE_FAILED = 0x23;

        public const byte FAILED_NODE_OK = 0x00;
        public const byte FAILED_NODE_REMOVED = 0x01;
        public const byte FAILED_NODE_NOT_REMOVED = 0x02;

        public const byte FAILED_NODE_REPLACE_WAITING = 0x03;
        public const byte FAILED_NODE_REPLACE_DONE = 0x04;
        public const byte FAILED_NODE_REPLACE_FAILED = 0x05;

        public const byte FAILED_NODE_REMOVE_STARTED = 0x00;
        public const byte FAILED_NODE_NOT_PRIMARY_CONTROLLER = 0x02;
        public const byte FAILED_NODE_NO_CALLBACK_FUNCTION = 0x04;
        public const byte FAILED_NODE_NOT_FOUND = 0x08;
        public const byte FAILED_NODE_REMOVE_PROCESS_BUSY = 0x10;
        public const byte FAILED_NODE_REMOVE_FAIL = 0x20;

        public const byte SUC_UPDATE_DONE = 0x00;
        public const byte SUC_UPDATE_ABORT = 0x01;
        public const byte SUC_UPDATE_WAIT = 0x02;
        public const byte SUC_UPDATE_DISABLED = 0x03;
        public const byte SUC_UPDATE_OVERFLOW = 0x04;

        public const byte SUC_FUNC_BASIC_SUC = 0x00;
        public const byte SUC_FUNC_NODEID_SERVER = 0x01;

        public const byte UPDATE_STATE_NODE_INFO_RECEIVED = 0x84;
        public const byte UPDATE_STATE_NODE_INFO_REQ_DONE = 0x82;
        public const byte UPDATE_STATE_NODE_INFO_REQ_FAILED = 0x81;
        public const byte UPDATE_STATE_ROUTING_PENDING = 0x80;
        public const byte UPDATE_STATE_NEW_ID_ASSIGNED = 0x40;
        public const byte UPDATE_STATE_DELETE_DONE = 0x20;
        public const byte UPDATE_STATE_SUC_ID = 0x10;

        public const byte APPLICATION_NODEINFO_LISTENING = 0x01;
        public const byte APPLICATION_NODEINFO_OPTIONAL_FUNCTIONALITY = 0x02;

        public const byte SLAVE_ASSIGN_COMPLETE = 0x00;
        public const byte SLAVE_ASSIGN_NODEID_DONE = 0x01;  // Node ID has been assigned
        public const byte SLAVE_ASSIGN_RANGE_INFO_UPDATE = 0x02;    // Node is doing neighbor discovery

        public const byte SLAVE_LEARN_MODE_DISABLE = 0x00;  // disable add/remove virtual slave nodes
        public const byte SLAVE_LEARN_MODE_ENABLE = 0x01;   // enable ability to include/exclude virtual slave nodes
        public const byte SLAVE_LEARN_MODE_ADD = 0x02;  // add node directly but only if primary/inclusion controller
        public const byte SLAVE_LEARN_MODE_REMOVE = 0x03;   // remove node directly but only if primary/inclusion controller

        public const byte OPTION_HIGH_POWER = 0x80;
        public const byte OPTION_NWI = 0x40;    // NWI Inclusion;

        //Device request related;
        public const byte BASIC_SET = 0x01;
        public const byte BASIC_REPORT = 0x03;

        public const byte COMMAND_CLASS_BASIC = 0x20;
        public const byte COMMAND_CLASS_CONTROLLER_REPLICATION = 0x21;
        public const byte COMMAND_CLASS_APPLICATION_STATUS = 0x22;
        public const byte COMMAND_CLASS_HAIL = 0x82;
    }
}
