import api from "./api";
const END_POINT = "ORDER";
const orderApi = () => {
        const getAll =()=>{
                return  api.get(END_POINT +"/GetAll");
        }
       return {getAll}
    
   
}
export default orderApi;