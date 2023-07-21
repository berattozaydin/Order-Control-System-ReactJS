import React,{Component, useEffect,useState} from "react";
import TestDataTable from "../OrderComp/TestDataTable";
import { Button } from "primereact/button";
class OrderPage extends Component {
    
render(){
    const getAll = ()=>{
        console.log("getirdim");
    }
    const useWatch = (fn, inputs) => useEffect(fn, inputs);
    const [s,t] = useState(false);
    useWatch(()=>{

    },[s])
    return(
        <div>
        <div className="p-grid">
            <div className="card">
                <Button label="Tıkla" onClick={getAll}/>
            </div>
            </div>
            <div className="p-grid">
                <TestDataTable/>
            </div>
            </div>
        

        );
}

}
export default OrderPage;