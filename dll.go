package main

import "C"
import (
	"bytes"
	"fmt"
	"net/http"
)

//export DisconnectUser
func DisconnectUser(token *C.char, serverid *C.char, victimid *C.char) *C.char {
	dtoken := C.GoString(token)
	dserverid := C.GoString(serverid)
	dvictimid := C.GoString(victimid)

	var jsonStr = []byte(`{"channel_id": null}`)
	req, err := http.NewRequest(http.MethodPatch, "https://discord.com/api/v9/guilds/"+string(dserverid)+"/members/"+string(dvictimid), bytes.NewBuffer(jsonStr))
	if err != nil {
		fmt.Println(err)
	}

	req.Header.Set("authorization", string(dtoken))
	req.Header.Set("Content-Type", "application/json")

	client := &http.Client{}
	_, err = client.Do(req)
	var ret string = ("Kicked " + string(dserverid) + " from the voice channel.")
	return C.CString(string(ret))
}

func main() {}
